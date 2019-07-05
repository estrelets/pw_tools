using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.RpcDatas;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
[OpCode(909)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PShopPlayerBuy_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int LocalsId {get; set; }
//µêÖ÷ROLEID
[Order(2)]
public int Master {get; set; }
[Order(3)]
public int ItemId {get; set; }
[Order(4)]
public int ItemPos {get; set; }
[Order(5)]
public int ItemCount {get; set; }
//³öÊÛÀ¸ÎïÆ·¸üÐÂ
[Order(6)]
public PShopItem Itemchange {get; set; }
}
}
