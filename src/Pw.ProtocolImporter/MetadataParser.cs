using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Pw.ProtocolImporter
{
    public class MetadataParser
    {
        private readonly TypeNameParsers _typeNameParsers = new TypeNameParsers();

        public StructDescriptor Parse(XmlDocument doc)
        {
            if (doc.DocumentElement.Name == "protocol")
                return ParseProtocol(doc);

            if (doc.DocumentElement.Name == "rpcdata")
                return ParseRpcData(doc);

            throw new NotSupportedException();
        }

        private Protocol ParseProtocol(XmlDocument doc)
        {
            var protocolNode = doc.DocumentElement;

            var protocol = new Protocol()
            {
                Name = GetAttributeValue(protocolNode, nameof(Protocol.Name)),
                Type = Int32.Parse(GetAttributeValue(protocolNode, nameof(Protocol.Type))),
                MaxSize = Int32.Parse(GetAttributeValue(protocolNode, nameof(Protocol.MaxSize))),
                Prior = Int32.Parse(GetAttributeValue(protocolNode, nameof(Protocol.Prior))),
                Variables = ParseVariables(protocolNode)
            };

            return protocol;
        }

        private RpcData ParseRpcData(XmlDocument doc)
        {
            var rpcDataNode = doc.DocumentElement;

            var protocol = new RpcData()
            {
                Name = GetAttr(nameof(RpcData.Name)),
                Attr = GetRpcDataAttr(nameof(RpcData.Attr)),
                Debug = GetOptionalInt(nameof(RpcData.Debug)),
                BdbTable = GetAttr(nameof(RpcData.BdbTable)),
                Key = GetAttr(nameof(RpcData.Key)),
                Variables = ParseVariables(rpcDataNode)
            };

            return protocol;

            string GetAttr(string name) => GetAttributeValue(rpcDataNode, name);
            RpcDataAttr GetRpcDataAttr(string name) => Enum.Parse<RpcDataAttr>(GetAttr(name) ?? nameof(RpcDataAttr.None), true);
            int? GetOptionalInt(string name) => GetAttr(name) == null ? default : Int32.Parse(GetAttr(name));
        }


        private Variable[] ParseVariables(XmlElement protocolNode)
        {
            var vars = new List<Variable>();

            foreach (XmlNode node in protocolNode.ChildNodes)
            {
                if (node is XmlComment commentNode)
                {
                    var comment = commentNode.Value;

                    var lastVar = vars.LastOrDefault();
                    if (lastVar != null)
                    {
                        lastVar.Comment = comment;
                    }

                    continue;
                }

                if (node.Name != "variable")
                    throw new NotImplementedException();

                if (node is XmlElement element)
                {
                    vars.Add(ParseVariable(element));
                }
            }

            return vars.ToArray();
        }

        private Variable ParseVariable(XmlElement element)
        {
            var type = ParseType();
            var attr = ParseAttr();

            var variable = new Variable()
            {
                Name = GetAttr(nameof(Variable.Name)),
                Type = type,
                Attr = attr,
                Default = GetAttr(nameof(Variable.Default))
            };

            return variable;

            BaseType ParseType() => _typeNameParsers.ParseType(GetAttr(nameof(Variable.Type)));
            Attr ParseAttr() => Enum.Parse<Attr>(GetAttr(nameof(Variable.Attr)) ?? "None", true);
            string GetAttr(string name) => GetAttributeValue(element, name);
        }


        private string GetAttributeValue(XmlNode node, string key)
        {
            foreach (XmlAttribute attr in node.Attributes)
            {
                if (attr.Name.Equals(key, StringComparison.InvariantCultureIgnoreCase))
                    return attr.Value;
            }

            return null;
        }
    }
}
