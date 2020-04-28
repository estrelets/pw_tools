using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(801)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AuctionOpen_Re
    {
        [Order(0)] public ushort RetCode { get; set; }

        [Order(1)] public uint AuctionId { get; set; }

        [Order(2)] public GAuctionItem Info { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
