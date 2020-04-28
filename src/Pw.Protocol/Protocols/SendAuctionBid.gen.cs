using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(822)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SendAuctionBid
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint AuctionId { get; set; }

        [Order(2)] public uint Bidprice { get; set; }

        [Order(3)] public char Bin { get; set; }

        [Order(4)] public uint LocalsId { get; set; }

        [Order(5)] public GMailSyncData SyncData { get; set; }
    }
}
