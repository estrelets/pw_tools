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
    public class ACLogInfo
    {
        [Order(0)]
        public int Type { get; set; }
        [Order(1)]
        public int SubId { get; set; }
        [Order(2)]
        public int LogTime { get; set; }
    }
}
