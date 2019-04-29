using System;

namespace Pw.ElementsSerializer.ValueAccessors
{
    public class ArrayValueAccessor : IValueAccessor, IValueAssigner
    {
        public int Index { get; }

        public ArrayValueAccessor(int index)
        {
            Index = index;
        }

        public void Set(object obj, object value)
        {
            var array = (Array)obj;
            array.SetValue(value, Index);
        }

        public object Get(object obj)
        {
            var array = (Array)obj;
            return array.GetValue(Index);
        }

        public override string ToString()
        {
            return $"[{Index}]";
        }
    }
}
