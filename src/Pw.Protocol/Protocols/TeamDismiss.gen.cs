using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8153)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TeamDismiss
    {
        [Order(0)] public long TeamId { get; set; }
    }
}
