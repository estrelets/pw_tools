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
    public class GCountryBattlePersonalScore
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public int Cls { get; set; }
        [Order(2)]
        public int MinorStr { get; set; }
        [Order(3)]
        public int CombatTime { get; set; }
        [Order(4)]
        public int AttendTime { get; set; }
        [Order(5)]
        public int KillCount { get; set; }
        [Order(6)]
        public int DeathCount { get; set; }
        [Order(7)]
        public int ContributeVal { get; set; }
        [Order(8)]
        public int Damage { get; set; }
        [Order(9)]
        public int Hurt { get; set; }
        [Order(10)]
        public int DamageMinorStr { get; set; }
        [Order(11)]
        public int KillMinorStr { get; set; }
    }
}
