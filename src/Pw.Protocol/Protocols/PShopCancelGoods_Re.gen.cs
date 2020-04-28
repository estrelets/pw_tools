﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(907)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopCancelGoods_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int LocalsId { get; set; }

        [Order(2)] public int Canceltype { get; set; }

//itemstore:È¡Ïû³öÊÛÓÐÐ§,±íÊ¾²Ö¿âÎïÆ·¸üÐÂ
        [Order(3)] public int Pos { get; set; }

        [Order(4)] public GRoleInventory Itemstore { get; set; }
    }
}
