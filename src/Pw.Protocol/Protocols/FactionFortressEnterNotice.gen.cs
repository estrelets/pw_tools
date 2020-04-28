using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4413)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionFortressEnterNotice
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int DstFactionId { get; set; }

        [Order(2)] public int DstWorldTag { get; set; }
    }
}
