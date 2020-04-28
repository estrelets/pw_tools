using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(362)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMShutupRole
    {
        [Order(0)] public int GmRoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int DstRoleId { get; set; }

        [Order(3)] public int ForbidTime { get; set; }

        [Order(4)] public byte[] Reason { get; set; }
    }
}
