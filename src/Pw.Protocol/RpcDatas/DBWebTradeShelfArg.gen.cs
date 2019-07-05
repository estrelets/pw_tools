﻿using System;
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
    public class DBWebTradeShelfArg
    {
        [Order(0)]
        public long Sn { get; set; }
        [Order(1)]
        public int RoleId { get; set; }
        [Order(2)]
        public int State { get; set; }
        [Order(3)]
        public int ShowEndtime { get; set; }
        [Order(4)]
        public int Price { get; set; }
        [Order(5)]
        public int SellEndtime { get; set; }
        [Order(6)]
        public int BuyerRoleId { get; set; }
    }
}
