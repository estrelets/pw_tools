using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4201)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceNewMail
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int RemainTime { get; set; }

        [Order(3)] public byte PresentType { get; set; }
    }
}
