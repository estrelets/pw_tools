﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBSyncSellInfoRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public List<SellPointInfo> List { get; set; }
    }
}
