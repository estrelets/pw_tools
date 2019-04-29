using System.Reflection;

namespace Pw.ElementsSerializer.ValueAccessors
{
    public class PropertyValueAccessor : IValueAccessor, IValueAssigner
    {
        public PropertyInfo PropertyInfo { get; }

        public PropertyValueAccessor(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
        }

        public object Get(object obj) => PropertyInfo.GetValue(obj);
        public void Set(object obj, object value) => PropertyInfo.SetValue(obj, value);

        public override string ToString()
        {
            return PropertyInfo.Name;
        }
    }
}
