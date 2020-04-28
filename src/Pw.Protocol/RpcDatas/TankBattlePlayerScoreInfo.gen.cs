using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TankBattlePlayerScoreInfo
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int KillCnt { get; set; }

        [Order(2)] public int DeadCnt { get; set; }

        [Order(3)] public int Score { get; set; }

        [Order(4)] public int Rank { get; set; }
    }
}
