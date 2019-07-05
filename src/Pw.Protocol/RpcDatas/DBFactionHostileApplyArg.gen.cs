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
    public class DBFactionHostileApplyArg
    {
        [Order(0)]
        public int FId { get; set; }
        [Order(1)]
        public int DstFId { get; set; }
        [Order(2)]
        public int EndTime { get; set; }
        [Order(3)]
        public int OpTime { get; set; }
    }
}
