using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(137)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceAuthdVersion
    {
        [Order(0)] public int AuVersion { get; set; }
    }
}
