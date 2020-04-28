using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4882)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TankBattlePlayerGetRank_Re
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int RetCode { get; set; }

        [Order(3)] public TankBattlePlayerScoreInfo YourScore { get; set; }

        [Order(4)] public TankBattlePlayerScoreInfo[] PlayerScoRes { get; set; }
    }
}
