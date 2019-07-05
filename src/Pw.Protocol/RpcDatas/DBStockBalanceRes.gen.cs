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
    public class DBStockBalanceRes
    {
        [Order(0)]
        public int RetCode { get; set; }
        [Order(1)]
        public int VolumeLeft { get; set; }
        [Order(2)]
        public int Cash { get; set; }
        [Order(3)]
        public int Money { get; set; }
    }
}
