using Pw.Serializer;

namespace Pw.Elements
{
    public class Skill
    {
        [Order(0)] public int Id { get; set; }

        [Order(1)] public int Level { get; set; }
    }
}
