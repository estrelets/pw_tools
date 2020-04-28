using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4415)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionFortressList_Re
    {
        [Order(0)] public int Status { get; set; }

        [Order(1)] public uint Begin { get; set; }

        [Order(2)] public List<GFactionFortressBriefInfo> List { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
