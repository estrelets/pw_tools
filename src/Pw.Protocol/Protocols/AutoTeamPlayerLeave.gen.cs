using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(968)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AutoTeamPlayerLeave
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public char Reason { get; set; }

        [Order(2)] public int LocalsId { get; set; }
    }
}
