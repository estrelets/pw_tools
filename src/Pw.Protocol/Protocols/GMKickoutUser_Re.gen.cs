using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(355)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMKickoutUser_Re
    {
        [Order(0)] public int RetCode { get; set; }

// roleid of game master 
        [Order(1)] public int GmRoleId { get; set; }

        [Order(2)] public int LocalsId { get; set; }

        [Order(3)] public int KickuserId { get; set; }
    }
}
