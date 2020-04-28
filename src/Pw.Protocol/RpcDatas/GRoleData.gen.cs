using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GRoleData
    {
        [Order(0)] public GRoleBase Base { get; set; }

        [Order(1)] public GRoleStatus Status { get; set; }

        [Order(2)] public GRolePocket Pocket { get; set; }

        [Order(3)] public GRoleEquipment Equipment { get; set; }

        [Order(4)] public GRoleStorehouse Storehouse { get; set; }

        [Order(5)] public GRoleTask Task { get; set; }
    }
}
