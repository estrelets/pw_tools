using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(620)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FindSellPointInfo_Re
    {
        [Order(0)] public uint LocalsId { get; set; }

        [Order(1)] public List<SellPointInfo> List { get; set; }
    }
}
