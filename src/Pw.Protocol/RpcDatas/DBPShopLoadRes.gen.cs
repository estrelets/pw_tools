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
    public class DBPShopLoadRes
    {
        [Order(0)]
        public short RetCode { get; set; }
        [Order(1)]
        public PShopDetail[] Shops { get; set; }
        [Order(2)]
        public byte[] Handle { get; set; }
    }
}
