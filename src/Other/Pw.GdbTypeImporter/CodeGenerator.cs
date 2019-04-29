using System.Linq;
using System.Text;

namespace Pw.GdbTypeImporter
{
    public class CodeGenerator
    {
        private readonly string _nameSpace;
        private readonly TypesCollector _typesCollector;
        private readonly StringBuilder _output;

        private int _indent;

        public CodeGenerator(string nameSpace, TypesCollector typesCollector)
        {
            _nameSpace = nameSpace;
            _typesCollector = typesCollector;
            _output = new StringBuilder();
        }

        public string Generate()
        {
            _output.Clear();

            PrintUsing();
            PrintNameSpaceStart();

            _indent = 4;

            PrintTypes();
            PrintEndScope();

            return _output.ToString();
        }

        private void PrintUsing()
        {
            AppendLine("using System;");
            AppendLine("using Pw.Serialization;");
            AppendLine();
        }

        private void PrintNameSpaceStart()
        {
            AppendLine($"namespace {_nameSpace}");
            AppendLine("{");
        }

        private void PrintEndScope()
        {
            AppendLine("}");
        }

        private void PrintTypes()
        {
            var types = _typesCollector.Types
              .Where(t => t.GetType().Name == nameof(GdbClass))
              .Cast<GdbClass>()
              .Select((gdbClass, order) => new { Class = gdbClass, Order = order });

            foreach (var gdbClass in types)
            {
                new ClassGenerator(gdbClass.Class, _typesCollector, _output, true, _indent).PrintType(gdbClass.Order);
                AppendLine();
            }
        }

        private void AppendLine(string str = null)
        {
            _output.AppendLine(str);
        }
    }
}
