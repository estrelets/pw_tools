﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4004)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TradeAddGoods
    {
        [Order(0)] public uint TId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public GRoleInventory Goods { get; set; }

        [Order(4)] public uint Money { get; set; }
    }
}
