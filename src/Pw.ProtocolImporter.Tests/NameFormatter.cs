using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pw.ProtocolImporter.Tests
{
    [TestClass]
    public class NameFormatterTests
    {
        [TestMethod]
        public void ReplaceSuffixes_ShouldReplaceAllSuffixes()
        {
            var source = "Someidarg";


            var formatted = NameFormatter.ReplacePostfix(source);


            Assert.AreEqual("Some_id_arg", formatted);
        }


        [TestMethod]
        public void ToCamelCase()
        {
            var source = "Someidarg";


            var formatted = NameFormatter.ToCamelCase(source);


            Assert.AreEqual("SomeIdArg", formatted);
        }
    }
}
