using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBCreateRoleArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public uint LogicuId { get; set; }

        [Order(2)] public int RoleId { get; set; }

        //variable name="real_referrer" type="int" default="0"/>		<variable name="referrer_role" type="int" default="0"/
        [Order(3)] public RoleInfo Roleinfo { get; set; }

        [Order(4)] public int AuSuggestReferrer { get; set; }

        [Order(5)] public int PlayerSuggestReferrer { get; set; }
    }
}
