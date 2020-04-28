using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8124)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleRelationResp
    {
        [Order(0)] public long UserId { get; set; }

        [Order(1)] public RoleBean Roleinfo { get; set; }

        [Order(2)] public FactionIDBean[] Factions { get; set; }

        [Order(3)] public RoleGroupBean[] Friends { get; set; }

        [Order(4)] public RoleInfoBean[] Blacklist { get; set; }
    }
}
