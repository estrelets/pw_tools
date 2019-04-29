using System.IO;
using Pw.Elements;

namespace Pw.ElementsYamlConverter
{
    public class YamlExporter
    {
        private readonly YamlSerializer _yamlSerializer;

        public YamlExporter(YamlSerializer yamlSerializer)
        {
            _yamlSerializer = yamlSerializer;
        }

        public void ExportAll(ElementsData data, string outputBin)
        {
            foreach (var list in data.Lists)
            {
                Save(list.Key, list.Value);
            }

            Save(nameof(ElementsDataFileInfo), data.ElementsDataFileInfo);

            void Save(string name, object value)
            {
                var path = Path.Combine(outputBin, $"{name}.yaml");
                using (var file = File.Create(path))
                {
                    _yamlSerializer.Serialize(value, file);
                }
            }
        }
    }
}
