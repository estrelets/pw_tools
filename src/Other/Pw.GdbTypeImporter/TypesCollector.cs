using System.Collections.Generic;
using System.Linq;

namespace Pw.GdbTypeImporter
{
    public class TypesCollector
    {
        public IReadOnlyCollection<IGdbType> Types => _types.AsReadOnly();

        public TypesCollector()
        {
            _anonymousClassCounter = 1;
            _types = new List<IGdbType>(CreatePrimitiveTypes());
        }

        private int _anonymousClassCounter;
        private readonly List<IGdbType> _types;

        public IGdbType GetOrAdd(string name)
        {
            var existingItem = _types.FirstOrDefault(t => t.Name == name);

            if (existingItem != null)
                return existingItem;

            var type = new GdbClass() { Name = name };
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


        private IGdbType[] CreatePrimitiveTypes()
        {
            return CppTerms.DefaultTypes.Select(type => new PrimitiveType() { Name = type }).ToArray();
        }
    }
}
