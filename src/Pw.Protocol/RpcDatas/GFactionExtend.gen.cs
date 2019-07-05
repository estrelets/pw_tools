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
    public class GFactionExtend
    {
        [Order(0)]
        public int Jointime { get; set; }
        [Order(1)]
        public int Loyalty { get; set; }
        [Order(2)]
        public int Logintime { get; set; }
        [Order(3)]
        public int Reserved1 { get; set; }
    }
}
