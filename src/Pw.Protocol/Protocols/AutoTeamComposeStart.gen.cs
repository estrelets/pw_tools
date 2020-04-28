using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(966)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AutoTeamComposeStart
    {
        [Order(0)] public int GoalId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public List<int> MemberList { get; set; }
    }
}
