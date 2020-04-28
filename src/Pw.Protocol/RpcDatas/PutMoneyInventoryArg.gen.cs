using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PutMoneyInventoryArg
    {
        [Order(0)] public uint RoleId { get; set; }

        [Order(1)] public uint Money { get; set; }

        [Order(2)] public GRoleInventory[] Goods { get; set; }
    }
}
