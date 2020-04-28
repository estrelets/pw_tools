using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Pw.Conventions;

namespace Pw.ProtocolImporter
{
    public class CodeGenerator
    {
        private readonly MetadataParser _metadataParser = new MetadataParser();

        private readonly Dictionary<string, string> _replaceMap =
            new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {
                ["int64_t"] = "long",
                ["Octets"] = "byte[]",
                ["OctetsVector"] = "List<byte[]>",
                ["std::map"] = "Dictionary",
                ["std::pair"] = "KeyValuePair",
                ["unsigned int"] = "uint",
                ["std::vector"] = "List",
                ["std::set"] = "List",
                ["unsigned short"] = "ushort",
                ["unsigned char"] = "byte",
                ["IntVector"] = "int[]",
                ["std::string"] = "string",
                ["size_t"] = "int",
                ["time_t"] = "int"
            };

        public void Generate(string path, string outputDirectory)
        {
            var descriptor = Load(path);
            var outputPath = GenerateOutputPath(path, outputDirectory);
            Save(outputPath, descriptor);
        }

        private string GenerateOutputPath(string sourcePath, string outputDirectory)
        {
            var fileName = Path.GetFileName(sourcePath);
            fileName = Path.ChangeExtension(fileName, ".gen.cs");
            return Path.Combine(outputDirectory, fileName);
        }

        private StructDescriptor Load(string path)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            return _metadataParser.Parse(xmlDoc);
        }

        private void Save(string path, StructDescriptor descriptor)
        {
            var classNameFromPath = Path.GetFileNameWithoutExtension(path).Replace(".gen", "");

            var content = descriptor switch
            {
                Protocol p => GenerateProtocol(p, classNameFromPath),
                RpcData rpcData => GenerateRpcData(rpcData, classNameFromPath),
                _ => throw new NotImplementedException()
            };

            File.WriteAllText(path, content, Encodings.Default);
        }

        private string GenerateProtocol(Protocol protocol, string classNameFromPath)
        {
            var output = new StringBuilder();

            WriteUsings(output, "System", "System.Collections.Generic", "System.CodeDom.Compiler", "Pw.Serializer",
                "Pw.RpcDatas");
            WriteDisableCheckComments(output);
            WriteNamespace(output, "Pw.Protocols");
            WriteAttribute(output, "OpCode", protocol.Type.ToString());
            WriteAttribute(output, "GeneratedCode", "\"Pw.ProtocolImporter\"", "\"1\"");
            WriteClassDefinition(output, protocol.Name, classNameFromPath);
            WriteProperties(output, protocol);
            WriteEndScope(output);
            WriteEndScope(output);

            return output.ToString();
        }

        private string GenerateRpcData(RpcData rpcData, string classNameFromPath)
        {
            var output = new StringBuilder();

            WriteUsings(output, "System", "System.Collections.Generic", "System.CodeDom.Compiler", "Pw.Serializer",
                "Pw.Protocols");
            WriteDisableCheckComments(output);
            WriteNamespace(output, "Pw.RpcDatas");
            WriteAttribute(output, "GeneratedCode", "\"Pw.ProtocolImporter\"", "\"1\"");
            WriteClassDefinition(output, rpcData.Name, classNameFromPath);
            WriteProperties(output, rpcData);
            WriteEndScope(output);
            WriteEndScope(output);

            return output.ToString();
        }

        private void WriteDisableCheckComments(StringBuilder sb)
        {
            WriteComment(sb, "ReSharper disable InconsistentNaming");
            WriteComment(sb, "ReSharper disable IdentifierTypo");
            WriteComment(sb, "ReSharper disable CommentTypo");
        }

        private void WriteUsings(StringBuilder sb, params string[] usings)
        {
            foreach (var @using in usings) sb.AppendLine($"using {@using};");

            sb.AppendLine();
        }

        private void WriteNamespace(StringBuilder sb, string namespaceName)
        {
            sb.AppendLine($"namespace {namespaceName}");
            WriteStartScope(sb);
        }

        private void WriteClassDefinition(StringBuilder sb, string className, string classNameFromPath)
        {
            className =
                className.Equals(classNameFromPath, StringComparison.InvariantCultureIgnoreCase)
                    ? classNameFromPath
                    : NameFormatter.ToCamelCase(className);

            sb.AppendLine($"public class {className}");
            WriteStartScope(sb);
        }

        private void WriteStartScope(StringBuilder sb)
        {
            sb.AppendLine("{");
        }

        private void WriteEndScope(StringBuilder sb)
        {
            sb.AppendLine("}");
        }

        private void WriteAttribute(StringBuilder sb, string attrName, params string[] parameters)
        {
            if (parameters.Length == 0)
                sb.AppendLine($"[{attrName}]");
            else
                sb.AppendLine($"[{attrName}({String.Join(", ", parameters)})]");
        }

        private void WriteComment(StringBuilder sb, string comment)
        {
            comment = comment.Replace("\r", "").Replace("\n", "");
            sb.AppendLine($"//{comment}");
        }

        private void WriteProperties(StringBuilder sb, StructDescriptor descriptor)
        {
            var order = 0;

            foreach (var variable in descriptor.Variables)
            {
                if (variable.Comment != null)
                    WriteComment(sb, variable.Comment);

                var typeName = ReplaceType(variable.Type);
                var propName = ReplaceName(variable);
                propName = NameFormatter.ToCamelCase(propName);

                WriteAttribute(sb, "Order", (order++).ToString());
                WriteProperty(sb, typeName, propName);
            }
        }

        private void WriteProperty(StringBuilder sb, string type, string name)
        {
            sb.AppendLine($"public {type} {name} {{get; set; }}");
        }

        private string ReplaceType(BaseType t)
        {
            if (t is GenericType genericType)
            {
                var parameters = genericType.Parameters.Select(ReplaceType);
                var parametersLine = String.Join(", ", parameters);
                return $"{ReplaceType(genericType.Generic)}<{parametersLine}>";
            }

            if (t is SimpleType simple)
            {
                if (_replaceMap.ContainsKey(simple.Name)) return _replaceMap[simple.Name];

                if (simple.Name.EndsWith("Vector")) return simple.Name.Replace("Vector", "[]");

                return simple.Name;
            }

            throw new NotImplementedException();
        }

        private string ReplaceName(Variable v)
        {
            return v.Name == "base"
                ? "@base"
                : v.Name;
        }
    }
}
