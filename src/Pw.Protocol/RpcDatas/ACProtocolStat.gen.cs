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
    public class ACProtocolStat
    {
        [Order(0)]
        public int Keepalive { get; set; }
        [Order(1)]
        public int Gamedatasend { get; set; }
        [Order(2)]
        public int Acreport { get; set; }
    }
}
