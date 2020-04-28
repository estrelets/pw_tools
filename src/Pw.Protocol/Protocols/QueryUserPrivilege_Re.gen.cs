using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(507)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class QueryUserPrivilege_Re
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public byte[] Auth { get; set; }
    }
}
