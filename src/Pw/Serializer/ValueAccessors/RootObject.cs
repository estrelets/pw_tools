namespace Pw.Serializer.ValueAccessors
{
    public class RootObject : IValueAccessor
    {
        public RootObject(string name = default)
        {
            Name = name;
        }

        public string Name { get; }

        public object Get(object obj)
        {
            return obj;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
