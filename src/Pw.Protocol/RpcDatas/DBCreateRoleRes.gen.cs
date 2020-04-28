using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBCreateRoleRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public uint Rolelist { get; set; }

        [Order(3)] public RoleInfo Roleinfo { get; set; }

        //variable name="referrer_name" type="Octets" default="Octets()" attr="ref"/
        [Order(4)] public int RealReferrer { get; set; }

        [Order(5)] public int RefretCode { get; set; }
    }
}
