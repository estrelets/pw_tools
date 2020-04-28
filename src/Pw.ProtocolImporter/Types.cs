using System;
using System.Linq;

namespace Pw.ProtocolImporter
{
    public abstract class BaseType
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class GenericType : BaseType
    {
        public GenericType(BaseType genericType, BaseType[] parameters)
        {
            if (!parameters.Any())
                throw new NotSupportedException();

            Generic = genericType;
            Parameters = parameters;
            Name = $"{Generic}<{String.Join(",", Parameters.Select(p => p.Name))}>";
        }

        public BaseType Generic { get; set; }
        public BaseType[] Parameters { get; set; }
    }

    public class SimpleType : BaseType
    {
        public SimpleType(string name)
        {
            Name = name;
        }
    }
}
