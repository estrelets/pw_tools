﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPShopCreateRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public PShopDetail Shop { get; set; }

        [Order(2)] public GMailSyncData SyncData { get; set; }
    }
}
