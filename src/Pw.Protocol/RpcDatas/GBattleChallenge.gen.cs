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
    public class GBattleChallenge
    {
        [Order(0)]
        public short Id { get; set; }
        [Order(1)]
        public uint Challenger { get; set; }
        [Order(2)]
        public uint Deposit { get; set; }
        [Order(3)]
        public uint Maxbonus { get; set; }
        [Order(4)]
        public uint CutoffTime { get; set; }
    }
}
