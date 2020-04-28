using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4877)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TankBattleStart
    {
        [Order(0)] public int BattleId { get; set; }

        [Order(1)] public int EndTime { get; set; }

        [Order(2)] public uint MaxPlayerCnt { get; set; }
    }
}
