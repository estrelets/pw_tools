using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(156)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ReportChat
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int DstRoleId { get; set; }

        [Order(3)] public byte[] DstRoleName { get; set; }

        [Order(4)] public byte[] Content { get; set; }
    }
}
