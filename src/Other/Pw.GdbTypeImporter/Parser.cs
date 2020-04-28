using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Pw.GdbTypeImporter
{
    public class Parser
    {
        private static readonly Regex TypeDeclarationPattern = new Regex("struct (.+) {", RegexOptions.Compiled);
        private static readonly Regex PropertyNamePattern = new Regex(" (\\w+)(\\[(\\d+)\\])*;", RegexOptions.Compiled);

        private readonly StreamReader _streamReader;
        private string _lastString;

        public Parser(StreamReader streamReader)
        {
            _streamReader = streamReader;
            NextLine();
        }

        public TypesCollector TypesCollector { get; } = new TypesCollector();

        public void Parse()
        {
            do
            {
                ParseType();
            } while (!_streamReader.EndOfStream);
        }

        private void ParseType()
        {
            SkipTrash();

            var typeName = ParseName();
            var type = TypesCollector.GetOrAdd(typeName);
            ParseProperties(type);

            void SkipTrash()
            {
                while (!TypeDeclarationPattern.IsMatch(_lastString)) NextLine();
            }

            string ParseName()
            {
                return TypeDeclarationPattern.Match(_lastString).Groups[1].Value;
            }
        }

        private void ParseProperties(IGdbType gdbType)
        {
            while (!IsEndOfScope(NextLine())) gdbType.Properties.Add(ParseProperty());
        }

        private Property ParseProperty()
        {
            var typeName = ParsePropertyType(_lastString);

            if (typeName == CppTerms.AnonymousStructDefinition)
            {
                var anonymousClass = new AnonymousClass();
                ParseProperties(anonymousClass);
                typeName = TypesCollector.GetAnonymousTypeName(anonymousClass);
            }

            var (name, count) = ParsePropertyName(_lastString);
            var type = TypesCollector.GetOrAdd(typeName);

            return count == null
                ? new Property(name, type)
                : new ArrayProperty(name, type, count.Value);
        }

        private string ParsePropertyType(string line)
        {
            var words = Split(line);

            return words[0] == CppTerms.UnsignedPrefix
                ? $"{words[0]} {words[1]}"
                : words[0];
        }

        private (string Name, int? Count) ParsePropertyName(string line)
        {
            var match = PropertyNamePattern.Match(line);

            if (!match.Success)
                throw new InvalidOperationException();

            var name = match.Groups[1].Value;
            int? count = null;

            if (Int32.TryParse(match.Groups[3].Value, out var parseResult)) count = parseResult;

            return (name, count);
        }


        private bool IsEndOfScope(string line)
        {
            return line.StartsWith("}");
        }

        private string NextLine()
        {
            return _lastString = _streamReader.ReadLine()?.Trim();
        }

        private string[] Split(string line)
        {
            return line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
