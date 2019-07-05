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
    public class DBStockBalanceArg
    {
        [Order(0)]
        public uint TId { get; set; }
        [Order(1)]
        public int UserId { get; set; }
        [Order(2)]
        public int AckVolume { get; set; }
        [Order(3)]
        public int AckMoney { get; set; }
    }
}
