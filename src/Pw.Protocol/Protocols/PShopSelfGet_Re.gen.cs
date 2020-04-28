using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(923)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopSelfGet_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int LocalsId { get; set; }

        [Order(2)] public PShopDetail Detail { get; set; }
    }
}
