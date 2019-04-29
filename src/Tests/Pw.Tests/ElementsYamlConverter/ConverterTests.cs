using System.IO;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pw.Elements;
using Pw.ElementsYamlConverter;
using Tests.Common;

namespace Pw.Tests.ElementsYamlConverter
{
    [TestClass]
    public class ConverterTests
    {
        private Stream _elementsStream;
        private ElementsData _elementsData;

        [TestInitialize]
        public void TestInit()
        {
            _elementsStream = EmbeddedResourceGetter.GetResourceStream(Resources.SampleElementsData);
            _elementsData = new ElementsData(_elementsStream);
        }

        [TestCleanup]
        public void TestClean() => _elementsStream.Dispose();


        [TestMethod]
        /* After serialize => deserialize \r\n converts to \n\n
           Workaround is set ScalarStyle = ScalarStyle.DoubleQuoted for string properties*/
        public void BugWithNewLine()
        {
            var yamlSerializer = new YamlSerializer();
            var npc1 = _elementsData.NpcEssences.FirstOrDefault(npc => npc.Id == 3273);

            var outputStream = new MemoryStream();
            yamlSerializer.Serialize(npc1, outputStream);

            var inputStream = new MemoryStream(outputStream.ToArray());
            var npc2 = yamlSerializer.DeSerialize<NpcEssence>(inputStream);

            npc1.Should().BeEquivalentTo(npc2);
        }
    }
}
