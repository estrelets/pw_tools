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
    public class GForceData
    {
        [Order(0)]
        public int ForceId { get; set; }
        [Order(1)]
        public int Reputation { get; set; }
        [Order(2)]
        public int Contribution { get; set; }
        [Order(3)]
        public int Reserved1 { get; set; }
        [Order(4)]
        public int Reserved2 { get; set; }
        [Order(5)]
        public int Reserved3 { get; set; }
        [Order(6)]
        public int Reserved4 { get; set; }
        [Order(7)]
        public int Reserved5 { get; set; }
        [Order(8)]
        public int Reserved6 { get; set; }
        [Order(9)]
        public int Reserved7 { get; set; }
    }
}
