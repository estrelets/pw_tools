using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(3065)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerGivePresent
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int TargetRoleId { get; set; }

        [Order(2)] public int MailId { get; set; }

        [Order(3)] public GRoleInventory[] Goods { get; set; }

        [Order(4)] public uint CashCost { get; set; }

        [Order(5)] public char HasGift { get; set; }

        [Order(6)] public int LogPrice1 { get; set; }

        [Order(7)] public int LogPrice2 { get; set; }

        [Order(8)] public byte[] SyncData { get; set; }
    }
}
