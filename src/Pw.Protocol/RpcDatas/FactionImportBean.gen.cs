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
    public class FactionImportBean
    {
        [Order(0)]
        public int Ftype { get; set; }
        [Order(1)]
        public long FactionId { get; set; }
        [Order(2)]
        public byte[] FactionName { get; set; }
        [Order(3)]
        public byte[] Announcement { get; set; }
        [Order(4)]
        public byte[] Extinfo { get; set; }
        [Order(5)]
        public TitleBean[] Members { get; set; }
    }
}
