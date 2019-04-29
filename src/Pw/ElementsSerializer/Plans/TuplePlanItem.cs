using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Pw.ElementsSerializer.ValueAccessors;

namespace Pw.ElementsSerializer.Plans
{
    public class TuplePlanItem : ICompositePlanItem
    {
        public IValueAccessor Accessor { get; }
        public Type TupleType { get; }
        public IReadOnlyList<IPlanItem> Childs { get; }

        public TuplePlanItem(IValueAccessor accessor, Type tupleType, IPlanItem[] childs)
        {
            if (!childs.All(c => c.Accessor is TupleValueAccessor))
                throw new NotSupportedException($"Childs accessor must be {nameof(TupleValueAccessor)}");

            Accessor = accessor;
            TupleType = tupleType;
            Childs = childs;
        }

        public void Serialize(object obj, Stream stream)
        {
            var tuple = Accessor.Get(obj);

            foreach (var child in Childs)
            {
                child.Serialize(tuple, stream);
            }
        }

        public object Deserialize(object obj, Stream stream)
        {
            var values = Childs.Select(c => c.Deserialize(obj, stream)).ToArray();
            var instance = Activator.CreateInstance(TupleType, values);

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, instance);
            }

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
