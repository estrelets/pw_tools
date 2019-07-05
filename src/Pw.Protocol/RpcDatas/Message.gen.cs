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
    public class Message
    {
        [Order(0)]
        public byte Channel { get; set; }
        [Order(1)]
        public byte[] SrcName { get; set; }
        [Order(2)]
        public int SrcRoleId { get; set; }
        [Order(3)]
        public byte[] DstName { get; set; }
        [Order(4)]
        public int DstRoleId { get; set; }
        [Order(5)]
        public byte[] Msg { get; set; }
    }
}
