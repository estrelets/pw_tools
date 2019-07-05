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
    public class GShopLog
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public int OrderId { get; set; }
        [Order(2)]
        public int ItemId { get; set; }
        [Order(3)]
        public int Expire { get; set; }
        [Order(4)]
        public int ItemCount { get; set; }
        [Order(5)]
        public int OrderCount { get; set; }
        [Order(6)]
        public int CashNeed { get; set; }
        [Order(7)]
        public int Time { get; set; }
        [Order(8)]
        public int Guid1 { get; set; }
        [Order(9)]
        public int Guid2 { get; set; }
    }
}
