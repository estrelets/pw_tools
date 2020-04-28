using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(609)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SyncSellInfo
    {
        [Order(0)] public SellPointInfo Info { get; set; }

        [Order(1)] public int Buyer { get; set; }
    }
}
