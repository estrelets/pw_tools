using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4878)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TankBattleStart_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int BattleId { get; set; }

        [Order(2)] public int WorldTag { get; set; }
    }
}
