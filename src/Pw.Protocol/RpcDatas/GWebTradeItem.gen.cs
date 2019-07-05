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
    public class GWebTradeItem
    {
        [Order(0)]
        public long Sn { get; set; }
        [Order(1)]
        public int SellerRoleId { get; set; }
        [Order(2)]
        public int SellerUserId { get; set; }
        [Order(3)]
        public byte[] SellerName { get; set; }
        //¼ÄÊÛÀàÐÍ:1:ÓÎÏ·±Ò2:ÎïÆ·
        [Order(4)]
        public int Posttype { get; set; }
        //¼ÄÊÛµÄÓÎÏ·±Ò£¬moneyºÍidÖ»ÄÜ´æÔÚÒ»¸ö
        [Order(5)]
        public uint Money { get; set; }
        //¼ÄÊÛµÄÎïÆ·id£¬moneyºÍidÖ»ÄÜ´æÔÚÒ»¸ö
        [Order(6)]
        public uint ItemId { get; set; }
        //¼ÄÊÛµÄÎïÆ·ÊýÁ¿
        [Order(7)]
        public int ItemCount { get; set; }
        [Order(8)]
        public int State { get; set; }
        [Order(9)]
        public int PostEndtime { get; set; }
        [Order(10)]
        public int ShowEndtime { get; set; }
        [Order(11)]
        public int Price { get; set; }
        [Order(12)]
        public int SellEndtime { get; set; }
        [Order(13)]
        public int BuyerRoleId { get; set; }
        [Order(14)]
        public int BuyerUserId { get; set; }
        [Order(15)]
        public byte[] BuyerName { get; set; }
        //ÉÌÆ·id£¬ÓÉÍøÒ³Éú³É
        [Order(16)]
        public int CommodityId { get; set; }
    }
}
