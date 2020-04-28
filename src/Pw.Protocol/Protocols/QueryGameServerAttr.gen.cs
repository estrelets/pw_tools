using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(512)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class QueryGameServerAttr
    {
        [Order(0)] public byte Paddings { get; set; }
    }
}
