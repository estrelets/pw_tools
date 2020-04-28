using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(366)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMForbidRole
    {
        [Order(0)] public byte FbdType { get; set; }

        [Order(1)] public int GmRoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public int DstRoleId { get; set; }

        [Order(4)] public int ForbidTime { get; set; }

        [Order(5)] public byte[] Reason { get; set; }
    }
}
