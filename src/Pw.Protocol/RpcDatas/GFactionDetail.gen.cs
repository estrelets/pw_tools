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
    public class GFactionDetail
    {
        [Order(0)]
        public uint FId { get; set; }
        [Order(1)]
        public byte[] Name { get; set; }
        [Order(2)]
        public char Level { get; set; }
        [Order(3)]
        public uint Master { get; set; }
        [Order(4)]
        public byte[] Announce { get; set; }
        [Order(5)]
        public byte[] Sysinfo { get; set; }
        [Order(6)]
        public FMemberInfo[] Member { get; set; }
        [Order(7)]
        public int LastOpTime { get; set; }
        [Order(8)]
        public GFactionAlliance[] Alliance { get; set; }
        [Order(9)]
        public GFactionHostile[] Hostile { get; set; }
        [Order(10)]
        public GFactionRelationApply[] Apply { get; set; }
    }
}
