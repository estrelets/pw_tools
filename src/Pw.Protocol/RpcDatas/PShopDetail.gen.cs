using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopDetail
    {
        [Order(0)] public int RoleId { get; set; }

        // ¹²8ÖÖ:0-7
        [Order(1)] public int Shoptype { get; set; }

        // 0:Õý³£;1:¹ýÆÚ 
        [Order(2)] public int Status { get; set; }

        [Order(3)] public int Createtime { get; set; }

        [Order(4)] public int Expiretime { get; set; }

        [Order(5)] public uint Money { get; set; }

        [Order(6)] public GRoleInventory[] Yinpiao { get; set; }

        [Order(7)] public PShopItem[] Blist { get; set; }

        [Order(8)] public PShopItem[] Slist { get; set; }

        [Order(9)] public GRoleInventory[] Store { get; set; }

        [Order(10)] public int Reserved1 { get; set; }

        [Order(11)] public int Reserved2 { get; set; }

        [Order(12)] public int Reserved3 { get; set; }

        [Order(13)] public int Reserved4 { get; set; }
    }
}
