using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleMsgBean
    {
        [Order(0)] public long Sender { get; set; }

        [Order(1)] public byte[] SenderName { get; set; }

        [Order(2)] public long Time { get; set; }

        [Order(3)] public int Emotiongroup { get; set; }

        [Order(4)] public byte[] Content { get; set; }
    }
}
