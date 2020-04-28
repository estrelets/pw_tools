using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBGetMailAttachRes
    {
        [Order(0)] public byte RetCode { get; set; }

        [Order(1)] public uint MoneyLeft { get; set; }

        [Order(2)] public uint ItemLeft { get; set; }

        [Order(3)] public GMailSyncData SyncData { get; set; }
    }
}
