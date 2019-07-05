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
    public class DBKEVotingArg
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public uint ItemId { get; set; }
        [Order(2)]
        public int ItemPos { get; set; }
        [Order(3)]
        public int ItemNum { get; set; }
        [Order(4)]
        public int CandidateRoleId { get; set; }
        [Order(5)]
        public GMailSyncData SyncData { get; set; }
    }
}
