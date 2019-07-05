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
    public class DBWebTradeCancelShelfArg
    {
        [Order(0)]
        public long Sn { get; set; }
        [Order(1)]
        public int RoleId { get; set; }
        [Order(2)]
        public int State { get; set; }
    }
}
