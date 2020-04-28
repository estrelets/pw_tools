using System;
using System.Collections.Generic;
using System.Linq;

namespace Pw.GdbTypeImporter
{
    public interface IGdbType
    {
        string Name { get; set; }
        List<Property> Properties { get; }
    }

    public class GdbClass : IGdbType
    {
        public virtual string Name { get; set; }
        public virtual List<Property> Properties { get; } = new List<Property>();
    }

    public class PrimitiveType : IGdbType
    {
        public string Name { get; set; }
        public List<Property> Properties => throw new InvalidOperationException();
    }

    public class AnonymousClass : GdbClass
    {
        public bool EqualsByProperties(AnonymousClass other)
        {
            if (Properties.Count != other.Properties.Count)
                return false;

            return Enumerable
                .Range(0, Properties.Count)
                .Select(i => new {Source = Properties[i], Other = other.Properties[i]})
                .All(pair => pair.Source.Equals(pair.Other));
        }
    }

    public class Property
    {
        public Property(string name, IGdbType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public IGdbType Type { get; }

        public override bool Equals(object obj)
        {
            if (obj is Property prop) return prop.Name == Name && prop.Type == Type;

            return false;
        }

        protected bool Equals(Property other)
        {
            return Name == other.Name && Equals(Type, other.Type);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Type);
        }

        public override string ToString()
        {
            return $"{Type.Name} {Name}";
        }
    }

    public class ArrayProperty : Property
    {
        public ArrayProperty(string name, IGdbType type, int count)
            : base(name, type)
        {
            Count = count;
        }

        public int Count { get; }

        public override string ToString()
        {
            return $"{Type.Name} {Name}[{Count}]";
        }
    }
}
