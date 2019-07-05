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
    public class GSysAuctionItem
    {
        [Order(0)]
        public uint SaId { get; set; }
        [Order(1)]
        public uint ItemId { get; set; }
        [Order(2)]
        public int ItemCount { get; set; }
        [Order(3)]
        public uint BasePrice { get; set; }
        [Order(4)]
        public int State { get; set; }
        [Order(5)]
        public int AuctionStarttime { get; set; }
        [Order(6)]
        public int AuctionEndtime { get; set; }
        [Order(7)]
        public uint BidPrice { get; set; }
        [Order(8)]
        public int BidTime { get; set; }
        [Order(9)]
        public int BidFreezetime { get; set; }
        [Order(10)]
        public int BidderRoleId { get; set; }
        [Order(11)]
        public int BidderUserId { get; set; }
    }
}
