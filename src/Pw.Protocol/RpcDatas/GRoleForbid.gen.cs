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
    public class GRoleForbid
    {
        [Order(0)]
        public byte Type { get; set; }
        [Order(1)]
        public int Time { get; set; }
        [Order(2)]
        public int Createtime { get; set; }
        [Order(3)]
        public byte[] Reason { get; set; }
    }
}