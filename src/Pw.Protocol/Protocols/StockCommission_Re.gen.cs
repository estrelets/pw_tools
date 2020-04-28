using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(409)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class StockCommission_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int Cash { get; set; }

        [Order(2)] public int Money { get; set; }

        [Order(3)] public List<StockPrice> Prices { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
