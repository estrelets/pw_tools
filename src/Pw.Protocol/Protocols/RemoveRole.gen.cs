using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8134)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RemoveRole
    {
        [Order(0)] public long UserId { get; set; }

        [Order(1)] public long RoleId { get; set; }
    }
}
