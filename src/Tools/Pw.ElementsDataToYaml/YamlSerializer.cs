using System;
using System.IO;
using System.Linq;
using System.Text;
using Pw.Conventions;
using Pw.Elements;
using Pw.Elements.v156;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace Pw.ElementsYamlConverter
{
    public class YamlSerializer
    {
        private static readonly Encoding FileEncoding = Encoding.UTF8;
        private readonly IDeserializer _yamlDeserializer;

        private readonly ISerializer _yamlSerializer;

        public YamlSerializer()
        {
            _yamlSerializer = YamlSerialization.CreateSerializer(RegisterAllOverrides);
            _yamlDeserializer = YamlSerialization.CreateDeserializer();
        }

        public void Serialize(object value, Stream outputStream)
        {
            using var writer = new StreamWriter(outputStream, FileEncoding);
            _yamlSerializer.Serialize(writer, value);
        }

        public T DeSerialize<T>(Stream inputStream)
        {
            using var reader = new StreamReader(inputStream);
            return _yamlDeserializer.Deserialize<T>(reader);
        }

        public object DeSerialize(Stream inputStream, Type type)
        {
            using var reader = new StreamReader(inputStream);
            return _yamlDeserializer.Deserialize(reader, type);
        }

        private static void RegisterAllOverrides(SerializerBuilder builder)
        {
            /* Workaround for replacing \r\n to \n\n */
            var elementsInterface = typeof(IElement);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .Where(ass => ass.FullName.StartsWith("Pw"))
                .SelectMany(s => s.GetTypes())
                .Where(p => elementsInterface.IsAssignableFrom(p));

            foreach (var type in types)
            foreach (var property in type.GetProperties().Where(p => p.PropertyType == typeof(string)))
                builder.WithAttributeOverride(type, property.Name,
                    new YamlMemberAttribute {ScalarStyle = ScalarStyle.DoubleQuoted});

            builder.WithAttributeOverride(
                typeof(TalkProc.Window.Option),
                nameof(TalkProc.Window.Option.Text),
                new YamlMemberAttribute {ScalarStyle = ScalarStyle.DoubleQuoted});

            builder.WithAttributeOverride(
                typeof(SoloTowerChallengeScoreCostConfig.ScoreBuffListClass),
                nameof(SoloTowerChallengeScoreCostConfig.ScoreBuffListClass.ParamComment),
                new YamlMemberAttribute {ScalarStyle = ScalarStyle.DoubleQuoted});
        }
    }
}
