using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class StockLog
    {
        [Order(0)] public uint TId { get; set; }

        [Order(1)] public int Time { get; set; }

        [Order(2)] public short Result { get; set; }

        [Order(3)] public short Volume { get; set; }

        [Order(4)] public int Cost { get; set; }
    }
}
