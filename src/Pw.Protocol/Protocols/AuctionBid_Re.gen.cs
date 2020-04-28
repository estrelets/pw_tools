using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(803)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AuctionBid_Re
    {
        [Order(0)] public ushort RetCode { get; set; }

        [Order(1)] public uint Bidprice { get; set; }

        [Order(2)] public uint AuctionId { get; set; }

        [Order(3)] public GAuctionItem Info { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
