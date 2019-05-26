using System;

namespace Pw.Serializer.ValueAccessors
{
    public class RootObject : IValueAccessor
    {
        public string Name { get; }

        public RootObject(string name = default)
        {
            Name = name;
        }

        public object Get(object obj)
        {
            return obj;
        }

        public override string ToString() => Name;
    }
}