using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GAuctionItem
    {
        [Order(0)] public uint AuctionId { get; set; }

        [Order(1)] public uint Bidprice { get; set; }

        [Order(2)] public uint Binprice { get; set; }

        [Order(3)] public uint EndTime { get; set; }

        [Order(4)] public uint ItemId { get; set; }

        [Order(5)] public ushort Count { get; set; }

        [Order(6)] public uint Seller { get; set; }

        [Order(7)] public uint Bidder { get; set; }
    }
}
