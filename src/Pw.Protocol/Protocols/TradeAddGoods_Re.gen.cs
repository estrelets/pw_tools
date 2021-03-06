﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4005)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TradeAddGoods_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public uint TId { get; set; }

        [Order(2)] public int OwnerRoleId { get; set; }

        [Order(3)] public int RoleId { get; set; }

        [Order(4)] public int LocalsId { get; set; }

        [Order(5)] public GRoleInventory Goods { get; set; }

        [Order(6)] public uint Money { get; set; }
    }
}
