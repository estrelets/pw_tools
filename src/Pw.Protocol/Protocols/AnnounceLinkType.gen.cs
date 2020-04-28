using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(372)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceLinkType
    {
        [Order(0)] public byte LinkType { get; set; }
    }
}
