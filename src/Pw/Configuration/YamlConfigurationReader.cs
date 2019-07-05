using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Pw.Conventions;
using YamlDotNet.Serialization;

namespace Pw.Configuration
{
    public class YamlConfigurationReader : IConfigurationReader
    {
        private readonly Dictionary<string, IConfigurationSection> _sections;
        private readonly IDeserializer _deserializer;

        public YamlConfigurationReader(Stream source, Action<DeserializerBuilder> customize = default)
        {
            _deserializer = YamlSerialization.CreateDeserializer(builder =>
            {
                RegisterTags(builder);
                customize?.Invoke(builder);
            });
            _sections = LoadSections(source);
        }

        public static YamlConfigurationReader FromFile(string configFilePath,
            Action<DeserializerBuilder> customize = default)
        {
            using var file = File.OpenRead(configFilePath);
            return new YamlConfigurationReader(file, customize);
        }

        public TSection Read<TSection>(string name) where TSection : IConfigurationSection
        {
            return (TSection)_sections[name];
        }

        private Dictionary<string, IConfigurationSection> LoadSections(Stream stream)
        {
            var reader = new StreamReader(stream);

            var config = _deserializer.Deserialize<Config>(reader);
            return config.Sections.ToDictionary(key => key.GetType().Name, value => value);
        }

        public static void Save(IConfigurationSection[] sections, Stream stream)
        {
            var serializer = YamlSerialization.CreateSerializer(RegisterTags);
            var config = new Config()
            {
                Sections = sections
            };

            using (var textWriter = new StreamWriter(stream, Encoding.UTF8, 1024, true))
            {
                serializer.Serialize(textWriter, config);
            }
        }

        private static void RegisterTags<T>(BuilderSkeleton<T> builder) where T : BuilderSkeleton<T>
        {
            foreach (var (name, type) in FindAllTags())
            {
                builder.WithTagMapping("!" + name, type);
            }

            builder.WithTagMapping("!Config", typeof(Config));
        }

        private static (string Name, Type Type)[] FindAllTags()
        {
            var sectionInterfaceType = typeof(IConfigurationSection);
            return
                AppDomain.CurrentDomain.GetAssemblies()
                    .Where(ass => ass.FullName.StartsWith("Pw"))
                    .SelectMany(s => s.GetTypes())
                    .Where(p => sectionInterfaceType.IsAssignableFrom(p))
                    .Select(t => (t.Name, t))
                    .ToArray();
        }

        private class Config
        {
            public IConfigurationSection[] Sections { get; set; }
        }
    }
}
