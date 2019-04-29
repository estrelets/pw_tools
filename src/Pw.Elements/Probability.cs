using Pw.ElementsSerializer;

namespace Pw.Elements
{
    public class Probability
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public float Prob { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Prob:P}";
        }
    }
}
