using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(3063)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PostPlayerRename
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int ZoneId { get; set; }

        [Order(2)] public int RetCode { get; set; }

        [Order(3)] public byte[] NewName { get; set; }

        [Order(4)] public byte[] OldName { get; set; }
    }
}
