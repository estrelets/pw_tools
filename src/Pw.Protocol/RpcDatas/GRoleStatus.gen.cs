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
    public class GRoleStatus
    {
        [Order(0)]
        public char Version { get; set; }
        [Order(1)]
        public int Level { get; set; }
        [Order(2)]
        public int Level2 { get; set; }
        [Order(3)]
        public int Exp { get; set; }
        [Order(4)]
        public int Sp { get; set; }
        [Order(5)]
        public int Pp { get; set; }
        [Order(6)]
        public int Hp { get; set; }
        [Order(7)]
        public int Mp { get; set; }
        [Order(8)]
        public float Posx { get; set; }
        [Order(9)]
        public float Posy { get; set; }
        [Order(10)]
        public float Posz { get; set; }
        [Order(11)]
        public int Worldtag { get; set; }
        [Order(12)]
        public int InvaderState { get; set; }
        [Order(13)]
        public int InvaderTime { get; set; }
        [Order(14)]
        public int PariahTime { get; set; }
        [Order(15)]
        public int Reputation { get; set; }
        [Order(16)]
        public byte[] CustomStatus { get; set; }
        [Order(17)]
        public byte[] FilterData { get; set; }
        [Order(18)]
        public byte[] Charactermode { get; set; }
        [Order(19)]
        public byte[] Instancekeylist { get; set; }
        [Order(20)]
        public int DbltimeExpire { get; set; }
        [Order(21)]
        public int DbltimeMode { get; set; }
        [Order(22)]
        public int DbltimeBegin { get; set; }
        [Order(23)]
        public int DbltimeUsed { get; set; }
        [Order(24)]
        public int DbltimeMax { get; set; }
        [Order(25)]
        public int TimeUsed { get; set; }
        [Order(26)]
        public byte[] DbltimeData { get; set; }
        [Order(27)]
        public ushort Storesize { get; set; }
        [Order(28)]
        public byte[] Petcorral { get; set; }
        [Order(29)]
        public byte[] Property { get; set; }
        [Order(30)]
        public byte[] VarData { get; set; }
        [Order(31)]
        public byte[] Skills { get; set; }
        [Order(32)]
        public byte[] Storehousepasswd { get; set; }
        [Order(33)]
        public byte[] Waypointlist { get; set; }
        [Order(34)]
        public byte[] Coolingtime { get; set; }
        [Order(35)]
        public byte[] NpcRelation { get; set; }
        [Order(36)]
        public byte[] MultiExpCtrl { get; set; }
        [Order(37)]
        public byte[] StorageTask { get; set; }
        [Order(38)]
        public byte[] FactionContrib { get; set; }
        [Order(39)]
        public byte[] ForceData { get; set; }
        [Order(40)]
        public byte[] OnlineAward { get; set; }
        [Order(41)]
        public byte[] ProfitTimeData { get; set; }
        [Order(42)]
        public byte[] CountryData { get; set; }
        [Order(43)]
        public byte[] KingData { get; set; }
        [Order(44)]
        public byte[] MeridianData { get; set; }
        [Order(45)]
        public byte[] Extraprop { get; set; }
        [Order(46)]
        public byte[] TitleData { get; set; }
        [Order(47)]
        public byte[] ReincarnationData { get; set; }
        [Order(48)]
        public byte[] RealmData { get; set; }
        [Order(49)]
        public char Reserved2 { get; set; }
        [Order(50)]
        public char Reserved3 { get; set; }
    }
}
