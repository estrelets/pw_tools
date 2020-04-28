using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPShopPlayerSellRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public GMailSyncData SyncData { get; set; }

        [Order(2)] public uint Money { get; set; }

        [Order(3)] public GRoleInventory[] Yinpiao { get; set; }

        //ÊÕ¹ºÀ¸ÎïÆ·¸üÐÂ
        [Order(4)] public PShopItem Itembuychange { get; set; }

        //²Ö¿âÎïÆ·¸üÐÂ
        [Order(5)] public GRoleInventory Itemstorechange { get; set; }
    }
}
