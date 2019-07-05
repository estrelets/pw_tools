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
    public class DBPlayerGivePresentArg
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public int UserId { get; set; }
        [Order(2)]
        public int TargetRoleId { get; set; }
        [Order(3)]
        public int MailId { get; set; }
        [Order(4)]
        public GRoleInventory[] Goods { get; set; }
        [Order(5)]
        public uint CashCost { get; set; }
        [Order(6)]
        public char HasGift { get; set; }
        [Order(7)]
        public int LogPrice1 { get; set; }
        [Order(8)]
        public int LogPrice2 { get; set; }
        [Order(9)]
        public byte[] RoleName { get; set; }
        [Order(10)]
        public GMailSyncData SyncData { get; set; }
    }
}
