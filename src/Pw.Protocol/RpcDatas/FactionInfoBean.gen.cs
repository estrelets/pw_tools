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
    public class FactionInfoBean
    {
        [Order(0)]
        public byte[] FactionName { get; set; }
        [Order(1)]
        public byte[] Announcement { get; set; }
        [Order(2)]
        public byte[] Extinfo { get; set; }
    }
}
