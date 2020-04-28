using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(545)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CertRequest
    {
        [Order(0)] public int Reserved1 { get; set; }
    }
}
