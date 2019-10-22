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
    public class FactionTitleBean
    {
        [Order(0)]
        public int TitleId { get; set; }
        [Order(1)]
        public byte[] TitleName { get; set; }
        [Order(2)]
        public RoleBean[] Titlemembers { get; set; }
    }
}