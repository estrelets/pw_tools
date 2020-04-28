using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4463)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerEnterLeaveGT
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public char Operation { get; set; }
    }
}
