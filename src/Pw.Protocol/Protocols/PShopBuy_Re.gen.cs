﻿using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.RpcDatas;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
[OpCode(903)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PShopBuy_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int LocalsId {get; set; }
[Order(2)]
public int ItemId {get; set; }
[Order(3)]
public int ItemPos {get; set; }
[Order(4)]
public int ItemCount {get; set; }
[Order(5)]
public uint ItemPrice {get; set; }
[Order(6)]
public PShopItem Itemsell {get; set; }
}
}