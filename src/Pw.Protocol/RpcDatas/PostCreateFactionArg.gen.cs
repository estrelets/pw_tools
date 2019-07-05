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
    public class PostCreateFactionArg
    {
        [Order(0)]
        public char Success { get; set; }
        [Order(1)]
        public int ZoneId { get; set; }
        [Order(2)]
        public int FactionId { get; set; }
        [Order(3)]
        public byte[] FactionName { get; set; }
    }
}
