using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Pw.Elements;

namespace Pw.ElementsYamlConverter
{
    public class YamlExporter
    {
        private readonly ThreadLocal<YamlSerializer> _serializer =
            new ThreadLocal<YamlSerializer>(() => new YamlSerializer());

        public void ExportAll(Pw.Elements.v155.ElementsData data, string outputBin)
        {
            Parallel.ForEach(data.Lists, list =>
            {
                Save(list.Key, list.Value);
            });

            Save(nameof(ElementsDataFileInfo), data.ElementsDataFileInfo);

            void Save(string name, object value)
            {
                var path = Path.Combine(outputBin, $"{name}.yaml");
                using var ms = new MemoryStream();
                _serializer.Value.Serialize(value, ms);
                File.WriteAllBytes(path, ms.ToArray());
            }
        }
    }
}
