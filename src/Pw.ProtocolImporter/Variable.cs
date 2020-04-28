namespace Pw.ProtocolImporter
{
    public class Variable
    {
        public string Name { get; set; }
        public BaseType Type { get; set; }
        public Attr Attr { get; set; }
        public object Default { get; set; }
        public string Comment { get; set; }
    }

    public enum Attr
    {
        None,
        Ref,
        Default
    }
}
