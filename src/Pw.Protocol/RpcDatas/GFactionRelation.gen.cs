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
    public class GFactionRelation
    {
        [Order(0)]
        public int FId { get; set; }
        [Order(1)]
        public int LastOpTime { get; set; }
        [Order(2)]
        public GFactionAlliance[] Alliance { get; set; }
        [Order(3)]
        public GFactionHostile[] Hostile { get; set; }
        [Order(4)]
        public GFactionRelationApply[] Apply { get; set; }
        [Order(5)]
        public int Reserved1 { get; set; }
        [Order(6)]
        public int Reserved2 { get; set; }
        [Order(7)]
        public int Reserved3 { get; set; }
        [Order(8)]
        public int Reserved4 { get; set; }
        [Order(9)]
        public int Reserved5 { get; set; }
    }
}
