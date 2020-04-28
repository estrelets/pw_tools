using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Pw.Elements;

namespace Pw.ElementsYamlConverter
{
    public class YamlConverter<TElementData>  where TElementData : IElementData, new ()
    {
        private readonly ThreadLocal<YamlSerializer> _serializerPool =
            new ThreadLocal<YamlSerializer>(() => new YamlSerializer());

        public void Export(IElementData data, string outputBin)
        {
            var properties = GetListsProperties();

            Export(nameof(ElementMetadata), data.ElementMetadata);
            Parallel.ForEach(properties, ExportList);

            void ExportList(PropertyInfo propertyInfo)
            {
                var type = propertyInfo.PropertyType.GetElementType();
                var list = propertyInfo.GetValue(data);
                Export(type.Name, list);
            }

            void Export(string name, object value)
            {
                using var memoryStream = new MemoryStream();
                var serializer = _serializerPool.Value;
                serializer.Serialize(value, memoryStream);

                var path = Path.Combine(outputBin, $"{name}.yaml");
                File.WriteAllBytes(path, memoryStream.ToArray());
            }
        }

        public TElementData Import(string directory)
        {
            var properties = GetListsProperties();
            var instance = new TElementData();

            instance.ElementMetadata = DeserializeMetadata();
            Parallel.ForEach(properties, DeserializeList);

            return instance;

            void DeserializeList(PropertyInfo propertyInfo)
            {
                var listType = propertyInfo.PropertyType;

                var itemType = listType.GetElementType();
                var path = CreatePath(itemType);
                var listData = Deserialize(path, listType);

                propertyInfo.SetValue(instance, listData);
            }

            ElementMetadata DeserializeMetadata()
            {
                var path = CreatePath(typeof(ElementMetadata));
                return (ElementMetadata)Deserialize(path, typeof(ElementMetadata));
            }

            object Deserialize(string path, Type type)
            {
                var file = File.ReadAllBytes(path);
                using var stream = new MemoryStream(file);
                var _yamlSerializer = _serializerPool.Value;

                return _yamlSerializer.DeSerialize(stream, type);
            }

            string CreatePath(Type type)
            {
                var listName = type.Name;
                var path = Path.Combine(directory, $"{listName}.yaml");
                return path;
            }
        }

        private static PropertyInfo[] GetListsProperties()
        {
            var elDataType = typeof(TElementData);
            return elDataType
                .GetProperties()
                .Where(p => p.PropertyType.IsArray)
                .Where(p => p.PropertyType
                    .GetElementType()
                    .GetInterfaces()
                    .Contains(typeof(IElement)))
                .ToArray();
        }
    }
}
