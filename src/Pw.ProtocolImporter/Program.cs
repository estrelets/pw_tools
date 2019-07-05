using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Pw.ProtocolImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cg = new CodeGenerator();

            //GenerateAllInDir(@"D:\pw\151Source\Service calls\rpcdata", @"../../../../Pw.Protocol/RpcDatas");
            GenerateAllInDir(@"D:\pw\151Source\Service calls\protocol", @"../../../../Pw.Protocol/Protocols");

            Console.WriteLine("Hello World!");

            void GenerateAllInDir(string dir, string outDir)
            {
                foreach (var file in Directory.GetFiles(dir, "*.xml"))
                {
                    cg.Generate(file, outDir);
                }
            }
        }


        #region trash region





        //static void Main(string[] args)
        //{
        //    var cg = new CodeGenerator();

        //    AnalyzeAllInDir(@"D:\pw\151Source\Service calls\rpcdata");
        //    //AnalyzeAllInDir(@"D:\pw\151Source\Service calls\rpc");
        //    //AnalyzeAllInDir(@"D:\pw\151Source\Service calls\protocol");



        //    Console.WriteLine("Protocol");
        //    Console.WriteLine(Print(_protocolAttributes));
        //    Console.WriteLine("Variable");
        //    Console.WriteLine(Print(_variableAttributes));


        //    Console.WriteLine("Hello World!");

        //    string Print(Dictionary<string, List<string>> dic)
        //    {
        //        var sb = new StringBuilder();
        //        foreach (var (key, value) in dic)
        //        {
        //            sb.Append(key + ":");
        //            sb.Append(string.Join('|', value));
        //            sb.AppendLine();
        //        }

        //        return sb.ToString();
        //    }

        //    void AnalyzeAllInDir(string dir)
        //    {

        //        foreach (var file in Directory.GetFiles(dir, "*.xml"))
        //        {
        //            var xmlDoc = new XmlDocument();
        //            xmlDoc.Load(file);
        //            Parse(xmlDoc);
        //            Analyze(xmlDoc);
        //        }
        //    }
        //}

        private static Dictionary<string, List<string>> _variableAttributes = new Dictionary<string, List<string>>();
        private static Dictionary<string, List<string>> _protocolAttributes = new Dictionary<string, List<string>>();

        static void Parse(XmlDocument xmlDoc)
        {
            new MetadataParser().Parse(xmlDoc);
        }

        static void Analyze(XmlDocument xmlDoc)
        {
            var root = xmlDoc.DocumentElement;

            GetUniqueAttrsForProtocol();



            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                if (node is XmlComment)
                    continue;

                if (node.Name != "variable")
                    throw new NotImplementedException();

                if (node is XmlElement element)
                {
                    GetUniqueAttrsForVariable(element);
                }
            }

            void GetUniqueAttrsForProtocol() => GetUniqueAttributes(root.Attributes, _protocolAttributes);
            void GetUniqueAttrsForVariable(XmlElement el) => GetUniqueAttributes(el.Attributes, _variableAttributes);
        }

        static void GetUniqueAttributes(XmlAttributeCollection attributes, Dictionary<string, List<string>> dic)
        {
            foreach (XmlAttribute attr in attributes)
            {
                var name = attr.Name;
                var value = attr.Value;

                if (!dic.ContainsKey(name))
                    dic[name] = new List<string>();

                if (!dic[name].Contains(value))
                    dic[name].Add(value);
            }
        }
    }
}
#endregion
