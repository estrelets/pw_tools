using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPlayerGivePresentRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public GMailHeader InformTarget { get; set; }

        [Order(2)] public GMailHeader InformTarget2 { get; set; }

        [Order(3)] public GMailSyncData SyncData { get; set; }
    }
}
