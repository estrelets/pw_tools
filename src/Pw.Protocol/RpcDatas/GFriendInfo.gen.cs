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
    public class GFriendInfo
    {
        [Order(0)]
        public int RId { get; set; }
        [Order(1)]
        public char Cls { get; set; }
        [Order(2)]
        public char GId { get; set; }
        [Order(3)]
        public byte[] Name { get; set; }
    }
}
