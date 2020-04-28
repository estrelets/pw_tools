using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class StockOrder
    {
        [Order(0)] public uint TId { get; set; }

        [Order(1)] public int Time { get; set; }

        [Order(2)] public int UserId { get; set; }

        [Order(3)] public int Price { get; set; }

        [Order(4)] public int Volume { get; set; }

        [Order(5)] public char Status { get; set; }
    }
}
