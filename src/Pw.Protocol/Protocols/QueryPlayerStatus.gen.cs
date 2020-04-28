using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(110)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class QueryPlayerStatus
    {
        [Order(0)] public int[] Rolelist { get; set; }
    }
}
