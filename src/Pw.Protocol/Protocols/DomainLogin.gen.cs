using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(700)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DomainLogin
    {
        [Order(0)] public byte[] Nonce { get; set; }

        [Order(1)] public uint LocalsId { get; set; }
    }
}
