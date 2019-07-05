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
    public class GRoleDetail
    {
        [Order(0)]
        public char Version { get; set; }
        [Order(1)]
        public uint Id { get; set; }
        [Order(2)]
        public uint UserId { get; set; }
        [Order(3)]
        public GRoleStatus Status { get; set; }
        [Order(4)]
        public byte[] Name { get; set; }
        [Order(5)]
        public int Race { get; set; }
        [Order(6)]
        public int Cls { get; set; }
        [Order(7)]
        public uint Spouse { get; set; }
        [Order(8)]
        public byte Gender { get; set; }
        [Order(9)]
        public int CreateTime { get; set; }
        [Order(10)]
        public int LastloginTime { get; set; }
        //ÀÛ¼Æ³äÖµ½ð¶î
        [Order(11)]
        public int CashAdd { get; set; }
        [Order(12)]
        public int CashTotal { get; set; }
        [Order(13)]
        public int CashUsed { get; set; }
        [Order(14)]
        public int CashSerial { get; set; }
        [Order(15)]
        public uint FactionId { get; set; }
        [Order(16)]
        public int FactionRole { get; set; }
        [Order(17)]
        public byte[] CustomData { get; set; }
        [Order(18)]
        public uint CustomStamp { get; set; }
        [Order(19)]
        public GRolePocket Inventory { get; set; }
        [Order(20)]
        public GRoleInventory[] Equipment { get; set; }
        [Order(21)]
        public GRoleStorehouse Storehouse { get; set; }
        [Order(22)]
        public GRoleTask Task { get; set; }
        [Order(23)]
        public byte[] Addiction { get; set; }
        [Order(24)]
        public List<GShopLog> Logs { get; set; }
        [Order(25)]
        public int BonusAdd { get; set; }
        [Order(26)]
        public int BonusReward { get; set; }
        [Order(27)]
        public int BonusUsed { get; set; }
        [Order(28)]
        public int Referrer { get; set; }
        [Order(29)]
        public GUserStorehouse Userstorehouse { get; set; }
        [Order(30)]
        public byte[] Taskcounter { get; set; }
        [Order(31)]
        public GFactionAlliance[] Factionalliance { get; set; }
        [Order(32)]
        public GFactionHostile[] Factionhostile { get; set; }
        [Order(33)]
        public int MallConsumption { get; set; }
        [Order(34)]
        public int SrcZoneId { get; set; }
    }
}
