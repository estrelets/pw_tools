using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GRoleTableClsconfig
    {
        [Order(0)] public char Version { get; set; }

        [Order(1)] public GRoleBase Base { get; set; }

        [Order(2)] public GRoleStatus Status { get; set; }

        [Order(3)] public GRolePocket Inventory { get; set; }

        [Order(4)] public GRoleInventory[] Equipment { get; set; }

        [Order(5)] public GRoleStorehouse Storehouse { get; set; }
    }
}
