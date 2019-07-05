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
    public class GFactionFortressBriefInfo
    {
        [Order(0)]
        public int FactionId { get; set; }
        [Order(1)]
        public int Level { get; set; }
        //ÉÏÏÞ20¸öint*2
        [Order(2)]
        public byte[] Building { get; set; }
        [Order(3)]
        public int Health { get; set; }
        [Order(4)]
        public int OffenseFaction { get; set; }
    }
}
