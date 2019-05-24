using System;

namespace Pw.Serializer
{
    public class NameStringAttribute : Attribute
    {
    }

    public class OrderAttribute : Attribute
    {
        public OrderAttribute(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }

    public class SizeAttribute : Attribute
    {
        public SizeAttribute(int size)
        {
            Size = size;
        }

        public int Size { get; }
    }

    public class DynamicSizeAttribute : Attribute
    {
    }

    public class CustomSerializerAttribute : Attribute
    {
        public Type SerializerType { get; set; }
    }
}
