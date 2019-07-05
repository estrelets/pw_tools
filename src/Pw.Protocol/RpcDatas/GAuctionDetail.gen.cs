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
    public class GAuctionDetail
    {
        [Order(0)]
        public GAuctionItem Info { get; set; }
        [Order(1)]
        public ushort Category { get; set; }
        [Order(2)]
        public uint Baseprice { get; set; }
        [Order(3)]
        public uint Deposit { get; set; }
        [Order(4)]
        public int ElapseTime { get; set; }
        [Order(5)]
        public int Prolong { get; set; }
        [Order(6)]
        public int Reserved1 { get; set; }
        [Order(7)]
        public int Reserved2 { get; set; }
        [Order(8)]
        public int Reserved3 { get; set; }
        [Order(9)]
        public GRoleInventory Item { get; set; }
    }
}
