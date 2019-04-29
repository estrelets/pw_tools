using System;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Pw.Conventions
{
    public static class YamlSerialization
    {
        public static ISerializer CreateSerializer(Action<SerializerBuilder> customize = default)
        {
            var builder = new SerializerBuilder();

            builder.EmitDefaults();
            builder.DisableAliases();
            builder.WithNamingConvention(new PascalCaseNamingConvention());

            customize?.Invoke(builder);

            return builder.Build();
        }

        public static IDeserializer CreateDeserializer(Action<DeserializerBuilder> customize = default)
        {
            var builder = new DeserializerBuilder();

            customize?.Invoke(builder);

            return builder.Build();
        }
    }
}
