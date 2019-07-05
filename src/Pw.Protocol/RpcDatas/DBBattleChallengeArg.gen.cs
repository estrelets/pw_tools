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
    public class DBBattleChallengeArg
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public short CityId { get; set; }
        [Order(2)]
        public int FactionId { get; set; }
        [Order(3)]
        public uint Deposit { get; set; }
        [Order(4)]
        public uint Maxbonus { get; set; }
        [Order(5)]
        public int ChallengeTime { get; set; }
        [Order(6)]
        public GMailSyncData SyncData { get; set; }
    }
}
