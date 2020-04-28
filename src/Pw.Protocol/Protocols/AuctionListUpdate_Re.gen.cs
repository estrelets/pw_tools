using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(824)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AuctionListUpdate_Re
    {
        [Order(0)] public uint LocalsId { get; set; }

        [Order(1)] public List<uint> ExpiredIds { get; set; }

        [Order(2)] public List<GAuctionItem> Items { get; set; }
    }
}
