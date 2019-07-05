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
    public class GReferral
    {
        [Order(0)]
        public int UserId { get; set; }
        [Order(1)]
        public int BonusTotal1 { get; set; }
        [Order(2)]
        public int BonusTotal2 { get; set; }
        [Order(3)]
        public int BonusWithdraw { get; set; }
        [Order(4)]
        public int BonusWithdrawToday { get; set; }
        [Order(5)]
        public int MaxRoleLevel { get; set; }
        [Order(6)]
        public List<byte[]> Rolenames { get; set; }
    }
}
