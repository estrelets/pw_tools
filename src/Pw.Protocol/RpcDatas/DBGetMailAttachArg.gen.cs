using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBGetMailAttachArg
    {
        [Order(0)] public GMailID MailId { get; set; }

        // money or object
        [Order(1)] public byte AttachType { get; set; }

        [Order(2)] public GMailSyncData SyncData { get; set; }
    }
}
