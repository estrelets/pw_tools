using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBStockTransactionRes
    {
        [Order(0)] public short RetCode { get; set; }

        [Order(1)] public int Cash { get; set; }

        [Order(2)] public int Money { get; set; }

        [Order(3)] public GMailSyncData SyncData { get; set; }
    }
}
