using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBStockCancelArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public uint TId { get; set; }

        [Order(2)] public int Volume { get; set; }

        [Order(3)] public short Result { get; set; }
    }
}
