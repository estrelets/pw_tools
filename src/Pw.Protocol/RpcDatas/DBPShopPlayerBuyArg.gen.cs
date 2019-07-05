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
    public class DBPShopPlayerBuyArg
    {
        //Íæ¼ÒROLEID
        [Order(0)]
        public int RoleId { get; set; }
        //µêÖ÷ROLEID
        [Order(1)]
        public int Master { get; set; }
        [Order(2)]
        public int ItemId { get; set; }
        [Order(3)]
        public int ItemPos { get; set; }
        [Order(4)]
        public int ItemCount { get; set; }
        [Order(5)]
        public long MoneyCost { get; set; }
        [Order(6)]
        public int YpCost { get; set; }
        [Order(7)]
        public GMailSyncData SyncData { get; set; }
    }
}
