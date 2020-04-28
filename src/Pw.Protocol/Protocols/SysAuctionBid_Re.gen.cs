using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4358)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SysAuctionBid_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public uint Cash { get; set; }

        [Order(2)] public GSysAuctionItem Info { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
