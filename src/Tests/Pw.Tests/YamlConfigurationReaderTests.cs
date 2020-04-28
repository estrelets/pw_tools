using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pw.Configuration;

namespace Pw.Tests
{
    [TestClass]
    public class YamlConfigurationReaderTests
    {
        [TestMethod]
        public void ShouldDeserialize()
        {
            var originalConfig = new SomeConfig1 {SomeValue = 123};
            var sections = new IConfigurationSection[] {originalConfig};


            var memoryStream = new MemoryStream();
            YamlConfigurationReader.Save(sections, memoryStream);

            memoryStream.Seek(0, SeekOrigin.Begin);
            var configReader = new YamlConfigurationReader(memoryStream);
            var deserializedConfig = configReader.Read<SomeConfig1>();


            deserializedConfig.Should().BeEquivalentTo(originalConfig);
        }
    }

    public class SomeConfig1 : IConfigurationSection
    {
        public string Name { get; set; } = nameof(SomeConfig1);

        public int SomeValue { get; set; }
    }
}
