using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBSetMailAttrArg
    {
        [Order(0)] public GMailID MailId { get; set; }

        [Order(1)] public byte AttribType { get; set; }

        [Order(2)] public byte AttribValue { get; set; }
    }
}
