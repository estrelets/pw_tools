using System.Reflection;

namespace Pw.Serializer.ValueAccessors
{
    public class PropertyValueAccessor : IValueAccessor, IValueAssigner
    {
        public PropertyValueAccessor(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
        }

        public PropertyInfo PropertyInfo { get; }

        public object Get(object obj)
        {
            return PropertyInfo.GetValue(obj);
        }

        public void Set(object obj, object value)
        {
            PropertyInfo.SetValue(obj, value);
        }

        public override string ToString()
        {
            return PropertyInfo.Name;
        }
    }
}
