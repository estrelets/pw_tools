using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBSysAuctionCashSpendRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public uint Cash { get; set; }

        [Order(2)] public uint CashUsed { get; set; }

        [Order(3)] public GMailHeader InformBidder { get; set; }
    }
}
