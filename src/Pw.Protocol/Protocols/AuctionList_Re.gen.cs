using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(805)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AuctionList_Re
    {
        [Order(0)] public uint LocalsId { get; set; }

        [Order(1)] public ushort Category { get; set; }

        [Order(2)] public uint End { get; set; }

        [Order(3)] public List<GAuctionItem> Items { get; set; }
    }
}
