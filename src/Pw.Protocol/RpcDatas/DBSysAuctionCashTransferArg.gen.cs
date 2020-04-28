using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBSysAuctionCashTransferArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public char Withdraw { get; set; }

        [Order(3)] public uint CashTransfer { get; set; }

        [Order(4)] public GMailSyncData SyncData { get; set; }
    }
}
