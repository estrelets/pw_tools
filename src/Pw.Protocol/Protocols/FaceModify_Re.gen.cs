using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(127)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FaceModify_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int TicketId { get; set; }

        [Order(3)] public int TicketPos { get; set; }

        [Order(4)] public uint Crc { get; set; }
    }
}
