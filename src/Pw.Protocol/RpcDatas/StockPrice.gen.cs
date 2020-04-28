using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class StockPrice
    {
        [Order(0)] public int Price { get; set; }

        [Order(1)] public int Volume { get; set; }
    }
}
