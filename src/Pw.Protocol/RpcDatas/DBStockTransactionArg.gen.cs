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
    public class DBStockTransactionArg
    {
        [Order(0)]
        public int UserId { get; set; }
        [Order(1)]
        public int RoleId { get; set; }
        [Order(2)]
        public char Withdraw { get; set; }
        [Order(3)]
        public int Cash { get; set; }
        [Order(4)]
        public int Money { get; set; }
        [Order(5)]
        public GMailSyncData SyncData { get; set; }
    }
}
