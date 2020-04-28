using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4412)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionFortressEnter
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int FactionId { get; set; }

        [Order(2)] public int DstFactionId { get; set; }
    }
}
