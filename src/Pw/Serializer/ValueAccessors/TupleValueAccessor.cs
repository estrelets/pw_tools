using System.Reflection;

namespace Pw.Serializer.ValueAccessors
{
    public class TupleValueAccessor : IValueAccessor
    {
        public TupleValueAccessor(FieldInfo fieldInfo)
        {
            FieldInfo = fieldInfo;
        }

        public FieldInfo FieldInfo { get; }

        public object Get(object obj)
        {
            return FieldInfo.GetValue(obj);
        }

        public override string ToString()
        {
            return FieldInfo.Name;
        }
    }
}
