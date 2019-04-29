using System;
using System.IO;
using CommandLine;
using Pw.Elements;

namespace Pw.ElementsYamlConverter
{
    class Program
    {
        static int Main(string[] args)
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
                var elData = new ElementsData(file);
                Console.WriteLine("Load completed.");

                Console.WriteLine("Exporting to yaml..");
                new YamlExporter(new YamlSerializer()).ExportAll(elData, option.YamlDirectory);
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
            var importer = new YamlImporter(new YamlSerializer());
            var elements = importer.Import(option.YamlDirectory);
            Console.WriteLine("Load completed.");

            Console.WriteLine("Exporting to elements.data..");
            using (var stream = File.Create(option.ElementsPath))
            {
                elements.Save(stream);
            }
            Console.WriteLine("ExportAll completed.");

            return 0;
        }
    }
}
