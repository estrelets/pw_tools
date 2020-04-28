using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionInviteArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int InvitedRoleId { get; set; }

        [Order(2)] public uint FactionId { get; set; }

        [Order(3)] public byte[] FactionName { get; set; }

        [Order(4)] public byte[] RoleName { get; set; }
    }
}
