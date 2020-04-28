using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(546)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CertAnswer
    {
        [Order(0)] public byte[] AuthdCert { get; set; }

        [Order(1)] public int Reserved1 { get; set; }
    }
}
