using System;

namespace Pw.Serializer.ValueAccessors
{
    public class ArrayValueAccessor : IValueAccessor, IValueAssigner
    {
        public ArrayValueAccessor(int index)
        {
            Index = index;
        }

        public int Index { get; }

        public object Get(object obj)
        {
            var array = (Array) obj;
            return array.GetValue(Index);
        }

        public void Set(object obj, object value)
        {
            var array = (Array) obj;
            array.SetValue(value, Index);
        }

        public override string ToString()
        {
            return $"[{Index}]";
        }
    }
}
