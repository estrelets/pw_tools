using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBTankBattleBonusArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Rank { get; set; }

        [Order(2)] public uint Money { get; set; }

        [Order(3)] public GRoleInventory Item { get; set; }
    }
}
