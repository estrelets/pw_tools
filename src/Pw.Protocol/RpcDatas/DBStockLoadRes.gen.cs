using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBStockLoadRes
    {
        [Order(0)] public short RetCode { get; set; }

        [Order(1)] public List<StockOrder> Orders { get; set; }

        [Order(2)] public byte[] Handle { get; set; }
    }
}
