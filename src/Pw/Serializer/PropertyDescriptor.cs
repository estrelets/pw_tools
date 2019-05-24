using System;
using System.Reflection;

namespace Pw.Serializer
{
    internal class PropertyDescriptor
    {
        public PropertyDescriptor(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
            var sizeAttribute = propertyInfo.GetCustomAttribute<SizeAttribute>(false);
            var orderAttribute = propertyInfo.GetCustomAttribute<OrderAttribute>(false);
            var nameStringAttribute = propertyInfo.GetCustomAttribute<NameStringAttribute>(false);
            var dynamicSizeAttribute = propertyInfo.GetCustomAttribute<DynamicSizeAttribute>(false);

            Order = orderAttribute.Number;
            Size = sizeAttribute?.Size ?? default;
            IsDynamicSize = dynamicSizeAttribute != null;
            IsNameChar = nameStringAttribute != null;

            PropertyType = propertyInfo.PropertyType;
            IsArray = PropertyType.IsArray;
            ElementType = IsArray ? PropertyType.GetElementType() : null;
        }

        public PropertyDescriptor(Type t)
        {
            PropertyType = t;
            IsArray = PropertyType.IsArray;
            ElementType = IsArray ? PropertyType.GetElementType() : null;
        }

        public int Size { get; set; }
        public int Order { get; set; }
        public bool IsNameChar { get; set; }
        public bool IsArray { get; set; }
        public bool IsDynamicSize { get; set; }
        public Type PropertyType { get; set; }
        public Type ElementType { get; set; }
        public PropertyInfo PropertyInfo { get; }
    }
}