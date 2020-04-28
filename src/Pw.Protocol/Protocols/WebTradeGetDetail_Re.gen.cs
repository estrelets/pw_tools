using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4315)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class WebTradeGetDetail_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public long Sn { get; set; }

        [Order(2)] public GWebTradeDetail Detail { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
