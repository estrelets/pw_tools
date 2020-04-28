using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4311)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class WebTradeGetItem_Re
    {
        [Order(0)] public List<long> Sns { get; set; }

        [Order(1)] public GRoleInventory[] Items { get; set; }

        [Order(2)] public List<byte[]> Rolebriefs { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
