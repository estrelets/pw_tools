using System;
using System.IO;
using CommandLine;
using Pw.Elements;

namespace Pw.ElementsYamlConverter
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            return Parser.Default
                .ParseArguments<YamlToElements, ElementsToYaml>(args)
                .MapResult(
                    (YamlToElements opts) => ExportElements(opts),
                    (ElementsToYaml opts) => ExportYaml(opts),
                    errs => 1
                );
        }

        private static int ExportYaml(IStartOption option)
        {
            Console.WriteLine("Converting from elements to yaml.");
            Console.WriteLine($"Elements.data path='{option.ElementsPath}'");
            Console.WriteLine($"Yaml directory path='{option.YamlDirectory}'");

            using (var file = File.OpenRead(option.ElementsPath))
            {
                Console.WriteLine("Loading elements.data..");
                var elDataSerializer = CreateSerializer(option.Version);
                var elData = elDataSerializer.Deserialize(file);
                Console.WriteLine("Load completed.");

                Console.WriteLine("Exporting to yaml..");

                ExportYaml(elData, option.YamlDirectory, option.Version);
                Console.WriteLine("ExportAll completed.");
            }

            return 0;
        }

        private static int ExportElements(IStartOption option)
        {
            Console.WriteLine("Converting from yaml to elements.");
            Console.WriteLine($"Elements.data path='{option.ElementsPath}'");
            Console.WriteLine($"Yaml directory path='{option.YamlDirectory}'");

            Console.WriteLine("Loading yaml..");
            var elements = ImportYaml(option.YamlDirectory, option.Version);
            Console.WriteLine("Load completed.");

            Console.WriteLine("Exporting to elements.data..");
            using var stream = File.Create(option.ElementsPath);
            var elDataSerializer = CreateSerializer(option.Version);
            elDataSerializer.Serialize(stream, elements);

            Console.WriteLine("ExportAll completed.");

            return 0;
        }

        private static void ExportYaml(IElementData elementData, string yamlDirectory, Version version)
        {
            switch (version)
            {
                case Version.V144:
                    new YamlConverter<Elements.v144.ElementData>().Export(elementData, yamlDirectory);
                    break;
                case Version.V156:
                    new YamlConverter<Elements.v156.ElementData>().Export(elementData, yamlDirectory);
                    break;
            }
        }

        private static IElementData ImportYaml(string yamlDirectory, Version version)
        {
            switch (version)
            {
                case Version.V144:
                    return new YamlConverter<Elements.v144.ElementData>().Import(yamlDirectory);
                case Version.V156:
                    return new YamlConverter<Elements.v156.ElementData>().Import(yamlDirectory);

                default: throw new NotImplementedException();
            }
        }

        private static IElementDataSerializer CreateSerializer(Version version)
        {
            return version switch
            {
                Version.V144 => new Elements.v144.ElementDataSerializer(),
                Version.V156 => new Elements.v156.ElementDataSerializer(),
            };
        }
    }
}
