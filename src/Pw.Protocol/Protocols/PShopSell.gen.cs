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
[OpCode(904)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PShopSell
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int ItemId {get; set; }
//ÎïÆ·ÔÚ³öÊÛÀ¸µÄÎ»ÖÃ
[Order(2)]
public int ItemPos {get; set; }
[Order(3)]
public int ItemCount {get; set; }
[Order(4)]
public uint ItemPrice {get; set; }
//ÎïÆ·ÔÚ°ü¹üÖÐµÄÎ»ÖÃ
[Order(5)]
public int InvPos {get; set; }
[Order(6)]
public byte[] SyncData {get; set; }
}
}
