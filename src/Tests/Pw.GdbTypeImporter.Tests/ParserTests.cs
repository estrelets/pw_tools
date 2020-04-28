using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Common;

namespace Pw.GdbTypeImporter.Tests
{
    [TestClass]
    public class ParserTests
    {
        private readonly string ResourceName = "Pw.GdbTypeImporter.Tests.TestData.GdbOutput1.txt";

        [TestMethod]
        public void TypeWithAnonymousStruct()
        {
            var reader = EmbeddedResourceGetter.GetReaderForResource(ResourceName);
            var parser = new Parser(reader);
            parser.Parse();

            var extendProp = parser.TypesCollector.GetOrAdd("extend_prop");
            var addonDamage = extendProp?.Properties?.FirstOrDefault(p => p.Name == "addon_damage");

            Assert.IsNotNull(extendProp);
            Assert.IsNotNull(addonDamage);
            Assert.AreEqual(2, addonDamage.Type.Properties.Count);
        }
    }
}
