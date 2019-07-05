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
[OpCode(911)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PShopPlayerSell_Re
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
//ÊÕ¹ºÀ¸ÎïÆ·¸üÐÂ
[Order(6)]
public PShopItem Itembuy {get; set; }
}
}
