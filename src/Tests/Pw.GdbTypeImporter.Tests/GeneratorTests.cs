using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Common;

namespace Pw.GdbTypeImporter.Tests
{
    [TestClass]
    public class GeneratorTests
    {
        private string ResourceName = "Pw.GdbTypeImporter.Tests.TestData.GdbOutput1.txt";

        [TestMethod]
        public void TypeWithAnonymousStruct()
        {
            var reader = EmbeddedResourceGetter.GetReaderForResource(ResourceName);
            var parser = new Parser(reader);
            parser.Parse();
            var generator = new CodeGenerator("Pw.Elements", parser.TypesCollector);

            var output = generator.Generate();
        }
    }
}
