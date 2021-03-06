﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBWebTradePrePostRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int BuyerUserId { get; set; }

        [Order(2)] public byte[] BuyerName { get; set; }

        [Order(3)] public byte[] Name { get; set; }

        [Order(4)] public byte[] Rolebrief { get; set; }

        [Order(5)] public GMailSyncData SyncData { get; set; }
    }
}
