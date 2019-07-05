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
    public class SellPointRes
    {
        [Order(0)]
        public int RetCode { get; set; }
        [Order(1)]
        public int SellId { get; set; }
        // create time 
        [Order(2)]
        public int Ctime { get; set; }
        // expire time 
        [Order(3)]
        public int Etime { get; set; }
        [Order(4)]
        public char Status { get; set; }
        [Order(5)]
        public int Money { get; set; }
    }
}
