using System.Collections.Generic;
using System.Linq;

namespace Pw.GdbTypeImporter
{
    public class TypesCollector
    {
        private readonly List<IGdbType> _types;

        private int _anonymousClassCounter;

        public TypesCollector()
        {
            _anonymousClassCounter = 1;
            _types = new List<IGdbType>(CreatePrimitiveTypes());
        }

        public IReadOnlyCollection<IGdbType> Types => _types.AsReadOnly();

        public IGdbType GetOrAdd(string name)
        {
            var existingItem = _types.FirstOrDefault(t => t.Name == name);

            if (existingItem != null)
                return existingItem;

            var type = new GdbClass {Name = name};
            _types.Add(type);

            return type;
        }

        public string GetAnonymousTypeName(AnonymousClass anonymousClass)
        {
            var existingItem = _types
                .Where(t => t is AnonymousClass)
                .Cast<AnonymousClass>()
                .FirstOrDefault(t => t.EqualsByProperties(anonymousClass));

            if (existingItem != null)
                return existingItem.Name;

            anonymousClass.Name = $"Anonymous{_anonymousClassCounter++}";
            _types.Add(anonymousClass);

            return anonymousClass.Name;
        }


        private PrimitiveType[] CreatePrimitiveTypes()
        {
            return CppTerms.DefaultTypes
                .Select(type => new PrimitiveType {Name = type})
                .ToArray();
        }
    }
}
