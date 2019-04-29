using System.Reflection;

namespace Pw.ElementsSerializer.ValueAccessors
{
    public class TupleValueAccessor : IValueAccessor
    {
        public FieldInfo FieldInfo { get; }

        public TupleValueAccessor(FieldInfo fieldInfo)
        {
            FieldInfo = fieldInfo;
        }

        public object Get(object obj) => FieldInfo.GetValue(obj);

        public override string ToString()
        {
            return FieldInfo.Name;
        }
    }
}
