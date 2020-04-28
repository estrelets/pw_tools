using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GReferrer
    {
        [Order(0)] public int UserId { get; set; }

        //×öÎªÉÏÏß´ÓËùÓÐÏÂÏßËùÌáÈ¡µÄºìÀûÀÛ¼ÆÖµ
        [Order(1)] public int BonusAdd { get; set; }
    }
}
