using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(504)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AccountingResponse
    {
        [Order(0)] public uint Stamp { get; set; }

        [Order(1)] public int UserId { get; set; }

        [Order(2)] public byte[] Authenticator { get; set; }
    }
}
