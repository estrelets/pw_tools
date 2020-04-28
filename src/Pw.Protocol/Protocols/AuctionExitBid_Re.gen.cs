using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(819)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AuctionExitBid_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public uint AuctionId { get; set; }
    }
}
