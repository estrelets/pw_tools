using Pw.Serializer;

namespace Pw.Elements
{
    public class MagicDefences
    {
        [Order(0)] public int Low { get; set; }
        [Order(1)] public int High { get; set; }
    }
}
