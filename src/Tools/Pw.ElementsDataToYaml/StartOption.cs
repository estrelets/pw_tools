using CommandLine;

namespace Pw.ElementsYamlConverter
{
    public interface IStartOption
    {
        string ElementsPath { get; set; }
        string YamlDirectory { get; set; }
    }

    [Verb("toElements", HelpText = "Converts from elements.data to yaml files")]
    public class YamlToElements : IStartOption
    {
        [Option('e', "elements", Required = true, HelpText = "Path to elements.data file.")]
        public string ElementsPath { get; set; }

        [Option('y', "yamlDir", Required = true, HelpText = "Directory to yaml files")]
        public string YamlDirectory { get; set; }
    }

    [Verb("toYaml", HelpText = "Converts from elements.data to yaml files")]
    public class ElementsToYaml : IStartOption
    {
        [Option('e', "elements", Required = true, HelpText = "Path to elements.data file.")]
        public string ElementsPath { get; set; }

        [Option('y', "yamlDir", Required = true, HelpText = "Directory to yaml files")]
        public string YamlDirectory { get; set; }
    }
}
