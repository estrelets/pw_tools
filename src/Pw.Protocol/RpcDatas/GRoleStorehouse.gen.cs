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
    public class GRoleStorehouse
    {
        [Order(0)]
        public uint Capacity { get; set; }
        [Order(1)]
        public uint Money { get; set; }
        [Order(2)]
        public GRoleInventory[] Items { get; set; }
        [Order(3)]
        public byte Size1 { get; set; }
        [Order(4)]
        public byte Size2 { get; set; }
        //ÕâÀïÊµ¼ÊÊÇ²ÄÁÏ
        [Order(5)]
        public GRoleInventory[] Dress { get; set; }
        //ÕâÀïÊµ¼ÊÊÇÊ±×°
        [Order(6)]
        public GRoleInventory[] Material { get; set; }
        [Order(7)]
        public byte Size3 { get; set; }
        //¿¨ÅÆ
        [Order(8)]
        public GRoleInventory[] Generalcard { get; set; }
        [Order(9)]
        public short Reserved { get; set; }
    }
}
