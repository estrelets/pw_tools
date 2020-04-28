using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(617)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TransBuyPoint_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public TransID TId { get; set; }

        [Order(2)] public SellID SellId { get; set; }

        [Order(3)] public int Buyer { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int Point { get; set; }

        [Order(6)] public int AId { get; set; }
    }
}
