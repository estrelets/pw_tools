using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Humanizer;

namespace Pw.GdbTypeImporter
{
    public class ClassGenerator
    {
        private static readonly string NestedTypePostfix = "Class";
        private static readonly string StringTypeName = "string";
        private static readonly string ProbabilityTypeName = "Probability";

        private readonly IGdbType _gClass;
        private readonly TypesCollector _typesCollector;
        private readonly StringBuilder _output;
        private readonly bool _isElementsType;
        private readonly StringBuilder _nestedClassOutput;
        private readonly Dictionary<IGdbType, string> _nestedClasses;

        private int _indent;

        public ClassGenerator(
            IGdbType gClass,
            TypesCollector typesCollector,
            StringBuilder output,
            bool isElementsType,
            int indent)
        {
            _gClass = gClass;
            _typesCollector = typesCollector;
            _output = output;
            _isElementsType = isElementsType;
            _indent = indent;
            _nestedClassOutput = new StringBuilder();
            _nestedClasses = new Dictionary<IGdbType, string>();
        }

        public void PrintType(int? order, string forceClassName = null)
        {
            GenerateNestedTypes(_gClass);

            if (order != null)
                PrintOrder(order.Value);

            PrintClassStart(forceClassName);
            _indent += 4;

            PrintProperties();
            PrintNestedTypes();

            _indent -= 4;
            PrintEndScope();
        }

        private void PrintProperties()
        {
            var properties = _gClass
              .Properties
              .Select((property, propOrder) => new { Property = property, Order = propOrder })
              .ToArray();

            foreach (var property in properties)
            {
                PrintProperty(property.Property, property.Order);

                if (property != properties.Last())
                    AppendLine();
            }
        }

        private void PrintNestedTypes()
        {
            if (_nestedClassOutput.Length == 0)
                return;

            _output.AppendLine();
            _output.AppendLine(_nestedClassOutput.ToString());
        }

        private void PrintProperty(Property property, int order)
        {
            PrintOrder(order);

            if (property is ArrayProperty arrayProperty)
            {
                PrintSize(arrayProperty.Count);
            }

            if (_typesCollector.GetOrAdd(CppTerms.NameCharType) == property.Type)
                AppendLine("[NameStringAttribute]");

            var typeName = FixTypeName(property.Type);

            if (property is ArrayProperty && typeName != StringTypeName)
            {
                AppendLine($"public {typeName}[] {ToCamelCase(property.Name)} {{get; set;}}");
            }
            else
            {
                AppendLine($"public {typeName} {ToCamelCase(property.Name)} {{get; set;}}");
            }
        }

        private void PrintClassStart(string forceClassName)
        {
            var name = forceClassName ?? ToCamelCase(_gClass.Name);
            var interfacePart = _isElementsType ? ": IElementsType" : "";
            AppendLine($"public class {name} {interfacePart}");
            AppendLine("{");
        }

        private void PrintEndScope()
        {
            AppendLine("}");
        }

        public string FixTypeName(IGdbType type)
        {
            if (ToUint(type, out var name))
                return name;

            if (ToStringType(type, out name))
                return name;

            if (ToProbability(type, out name))
                return name;

            if (ToTuple(type, out name))
                return name;

            if (ToNestedType(type, out name))
                return name;

            return type.Name;
        }

        private bool ToUint(IGdbType type, out string name)
        {
            if (_typesCollector.GetOrAdd(CppTerms.UIntType) == type)
            {
                name = "uint";
                return true;
            }

            name = null;
            return false;
        }

        private bool ToStringType(IGdbType type, out string name)
        {
            if (_typesCollector.GetOrAdd(CppTerms.CharType) == type)
            {
                name = StringTypeName;
                return true;
            }

            if (_typesCollector.GetOrAdd(CppTerms.NameCharType) == type)
            {
                name = StringTypeName;
                return true;
            }

            name = null;
            return false;
        }

        private bool ToProbability(IGdbType type, out string name)
        {
            if (IsProbability(type))
            {
                name = ProbabilityTypeName;
                return true;
            }

            name = null;
            return false;
        }

        private bool IsProbability(IGdbType type)
        {
            if (type is PrimitiveType)
                return false;

            if (type.Properties.Count != 2)
                return false;

            if (_typesCollector.GetOrAdd(CppTerms.UIntType) != type.Properties[0].Type)
                return false;

            if (_typesCollector.GetOrAdd(CppTerms.FloatType) != type.Properties[1].Type)
                return false;

            if (!type.Properties[1].Name.Contains("probability"))
                return false;

            return true;
        }

        private bool ToTuple(IGdbType type, out string name)
        {
            if (IsTuple(type))
            {
                var tupleArgs = type.Properties
                  .Select(prop => $"{FixTypeName(prop.Type)} {ToCamelCase(prop.Name)}")
                  .ToArray();

                name = $"({String.Join(", ", tupleArgs)})";
                return true;
            }

            name = null;
            return false;
        }

        private bool IsTuple(IGdbType type)
        {
            if (type is PrimitiveType)
                return false;

            if (type.Properties.Count > 3)
                return false;

            var isPrimitives = type.Properties.All(p => p.Type is PrimitiveType && !(p is ArrayProperty));
            if (!isPrimitives)
                return false;

            return true;
        }

        private bool ToNestedType(IGdbType type, out string name)
        {
            name = null;

            if (!(type is AnonymousClass))
                return false;

            name = _nestedClasses[type];
            return true;
        }

        private void GenerateNestedTypes(IGdbType gClass)
        {
            var propertiesWithNestedClassType = gClass.Properties
              .Where(property => property.Type is AnonymousClass)
              .Where(property => !IsTuple(property.Type))
              .Where(property => !IsProbability(property.Type));

            foreach (var property in propertiesWithNestedClassType)
            {
                var name = ToCamelCase(property.Name) + NestedTypePostfix;
                var type = property.Type;
                new ClassGenerator(type, _typesCollector, _nestedClassOutput, false, _indent + 4)
                  .PrintType(null, name);

                _nestedClasses[type] = name;
            }
        }

        private string ToCamelCase(string name)
        {
            name = name.Replace("_", " ");
            name = name.Transform(To.LowerCase);
            name = name.Transform(To.TitleCase);
            name = name.Pascalize();
            return name;
        }

        private void PrintOrder(int order) => AppendLine($"[Order({order})]");
        private void PrintSize(int count) => AppendLine($"[Size({count})]");
        private void AppendLine(string str = null) => _output.AppendLine(new string(' ', _indent) + str);
    }
}
