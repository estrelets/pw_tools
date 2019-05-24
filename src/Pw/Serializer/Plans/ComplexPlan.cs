using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Pw.Serializer.Readers;
using Pw.Serializer.ValueAccessors;
using Pw.Serializer.Writers;

namespace Pw.Serializer.Plans
{
    public class ComplexPlan : ICompositePlanItem
    {
        public Type Type { get; }
        public IValueAccessor Accessor { get; }
        public IReadOnlyList<IPlanItem> Childs { get; }

        public ComplexPlan(IEnumerable<IPlanItem> childs, Type type, IValueAccessor accessor)
        {
            Type = type;
            Accessor = accessor;
            Childs = childs.ToArray();
        }

        public void Serialize(object obj, IWriter writer, Stream stream)
        {
            var value = (Accessor is RootObject) ? obj : Accessor.Get(obj);
            foreach (var child in Childs)
            {
                child.Serialize(value, writer, stream);
            }
        }

        public object Deserialize(object obj, IReader reader, Stream stream)
        {
            var instance = Activator.CreateInstance(Type);

            foreach (var child in Childs)
            {
                child.Deserialize(instance, reader, stream);
            }

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, instance);
            }

            return instance;
        }

        public override string ToString()
        {
            return ComplexPlanPrinter.Print(this, 0);
        }
    }
}
