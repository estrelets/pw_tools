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
    public class GForceGlobalDataBrief
    {
        [Order(0)]
        public int ForceId { get; set; }
        [Order(1)]
        public int PlayerCount { get; set; }
        [Order(2)]
        public int Development { get; set; }
        [Order(3)]
        public int Construction { get; set; }
        [Order(4)]
        public int Activity { get; set; }
        [Order(5)]
        public int ActivityLevel { get; set; }
    }
}
