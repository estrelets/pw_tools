using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4763)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleStart
    {
        [Order(0)] public int BattleId { get; set; }

        [Order(1)] public uint Defender { get; set; }

        [Order(2)] public uint Attacker { get; set; }

        [Order(3)] public uint PlayerLimit { get; set; }

        [Order(4)] public int EndTime { get; set; }

        [Order(5)] public uint DefenderPlayerCnt { get; set; }

        [Order(6)] public uint AttackerPlayerCnt { get; set; }

        [Order(7)] public uint CountryMaxPlayerCnt { get; set; }
    }
}
