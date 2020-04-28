using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(387)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class IWebAutolockGet
    {
        [Order(0)] public int TId { get; set; }

        [Order(1)] public int UserId { get; set; }
    }
}
