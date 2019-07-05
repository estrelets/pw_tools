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
    public class DBWebTradePrePostArg
    {
        [Order(0)]
        public long Sn { get; set; }
        [Order(1)]
        public int RoleId { get; set; }
        [Order(2)]
        public int UserId { get; set; }
        [Order(3)]
        public byte[] Name { get; set; }
        [Order(4)]
        public int Posttype { get; set; }
        [Order(5)]
        public uint Money { get; set; }
        [Order(6)]
        public uint ItemId { get; set; }
        [Order(7)]
        public int ItemPos { get; set; }
        [Order(8)]
        public int ItemNum { get; set; }
        [Order(9)]
        public int Price { get; set; }
        [Order(10)]
        public int Sellperiod { get; set; }
        [Order(11)]
        public int BuyerRoleId { get; set; }
        [Order(12)]
        public long PostTime { get; set; }
        [Order(13)]
        public int State { get; set; }
        [Order(14)]
        public uint Deposit { get; set; }
        [Order(15)]
        public int Loginip { get; set; }
        [Order(16)]
        public GMailSyncData SyncData { get; set; }
    }
}
