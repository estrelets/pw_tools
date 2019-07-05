using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.Protocols;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPShopPlayerBuyRes
    {
        [Order(0)]
        public int RetCode { get; set; }
        [Order(1)]
        public GMailSyncData SyncData { get; set; }
        [Order(2)]
        public uint Money { get; set; }
        [Order(3)]
        public GRoleInventory[] Yinpiao { get; set; }
        //³öÊÛÀ¸ÎïÆ·¸üÐÂ
        [Order(4)]
        public PShopItem Itemchange { get; set; }
    }
}
