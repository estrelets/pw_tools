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
    public class GChallengerInfo
    {
        [Order(0)]
        public uint Faction { get; set; }
        [Order(1)]
        public int Time { get; set; }
        [Order(2)]
        public uint Deposit { get; set; }
    }
}
