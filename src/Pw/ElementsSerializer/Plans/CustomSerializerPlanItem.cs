using System;
using System.IO;
using Pw.ElementsSerializer.ValueAccessors;

namespace Pw.ElementsSerializer.Plans
{
    public class CustomSerializerPlanItem : IPlanItem
    {
        public IValueAccessor Accessor { get; }
        public Type SerializerType { get; }
        public ICustomSerializer Serializer { get; }

        public CustomSerializerPlanItem(IValueAccessor accessor, Type serializerType)
        {
            Accessor = accessor;
            SerializerType = serializerType;
            Serializer = (ICustomSerializer)Activator.CreateInstance(serializerType);
        }

        public void Serialize(object obj, Stream stream)
        {
            var value = Accessor.Get(obj);
            Serializer.Serialize(value, stream);
        }

        public object Deserialize(object obj, Stream stream)
        {
            var value = Serializer.Deserialize(stream);

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, value);
            }

            return value;
        }
    }
}
