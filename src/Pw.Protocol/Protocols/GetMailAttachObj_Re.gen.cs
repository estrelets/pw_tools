using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4207)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetMailAttachObj_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public byte MailId { get; set; }

        [Order(2)] public uint MoneyLeft { get; set; }

        [Order(3)] public uint ItemLeft { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
