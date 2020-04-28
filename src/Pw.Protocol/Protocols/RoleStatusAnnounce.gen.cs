using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(7)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleStatusAnnounce
    {
        [Order(0)] public char ZoneId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public byte Status { get; set; }

        [Order(4)] public byte[] RoleName { get; set; }
    }
}
