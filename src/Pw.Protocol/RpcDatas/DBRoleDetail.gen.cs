using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBRoleDetail
    {
        [Order(0)] public RoleInfoBean Info { get; set; }

        [Order(1)] public RoleForbidBean ForbId { get; set; }
    }
}
