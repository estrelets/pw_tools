using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pw.Serializer.Readers;
using Pw.Serializer.ValueAccessors;
using Pw.Serializer.Writers;

namespace Pw.Serializer.Plans
{
    public class TuplePlanItem : ICompositePlanItem
    {
        public TuplePlanItem(IValueAccessor accessor, Type tupleType, IPlanItem[] childs)
        {
            if (!childs.All(c => c.Accessor is TupleValueAccessor))
                throw new NotSupportedException($"Childs accessor must be {nameof(TupleValueAccessor)}");

            Accessor = accessor;
            TupleType = tupleType;
            Childs = childs;
        }

        public Type TupleType { get; }
        public IValueAccessor Accessor { get; }
        public IReadOnlyList<IPlanItem> Childs { get; }

        public void Serialize(object obj, IWriter writer, Stream stream)
        {
            var tuple = Accessor.Get(obj);

            foreach (var child in Childs) child.Serialize(tuple, writer, stream);
        }

        public object Deserialize(object obj, IReader reader, Stream stream)
        {
            var values = Childs.Select(c => c.Deserialize(obj, reader, stream)).ToArray();
            var instance = Activator.CreateInstance(TupleType, values);

            if (Accessor is IValueAssigner setter) setter.Set(obj, instance);

            return instance;
        }


        public static bool IsTuple(Type t)
        {
            if (!t.IsGenericType)
                return false;

            var typeDef = t.GetGenericTypeDefinition();

            return typeDef == typeof(ValueTuple<,>)
                   || typeDef == typeof(ValueTuple<,,>)
                   || typeDef == typeof(ValueTuple<,,,>);
        }
    }
}
