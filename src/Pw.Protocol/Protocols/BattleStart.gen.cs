using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(857)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class BattleStart
    {
        [Order(0)] public int BattleId { get; set; }

        [Order(1)] public int MapType { get; set; }

        [Order(2)] public int BattleType { get; set; }

        [Order(3)] public uint Defender { get; set; }

        [Order(4)] public uint Attacker { get; set; }

        [Order(5)] public int EndTime { get; set; }
    }
}
