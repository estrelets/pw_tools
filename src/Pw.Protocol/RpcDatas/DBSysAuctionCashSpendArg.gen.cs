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
    public class DBSysAuctionCashSpendArg
    {
        [Order(0)]
        public int UserId { get; set; }
        [Order(1)]
        public int RoleId { get; set; }
        [Order(2)]
        public uint CashSpend { get; set; }
        [Order(3)]
        public uint SaId { get; set; }
        [Order(4)]
        public GRoleInventory Item { get; set; }
    }
}
