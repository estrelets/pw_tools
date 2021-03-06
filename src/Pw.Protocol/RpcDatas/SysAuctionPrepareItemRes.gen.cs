﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SysAuctionPrepareItemRes
    {
        [Order(0)] public List<int> Indexes { get; set; }

        [Order(1)] public GRoleInventory[] Items { get; set; }
    }
}
