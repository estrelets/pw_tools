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
[OpCode(8053)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class BillingConfirm_Re
{
//0³É¹¦£¬·Ç0Ê§°Ü
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int UserId {get; set; }
[Order(2)]
public int ItemId {get; set; }
[Order(3)]
public int Itemcnt {get; set; }
[Order(4)]
public byte[] ItemName {get; set; }
[Order(5)]
public int Itemexpire {get; set; }
[Order(6)]
public int Itemprice {get; set; }
[Order(7)]
public int Cashremain {get; set; }
//billing system Éú³É¶©µ¥ºÅ
[Order(8)]
public byte[] Chargeno {get; set; }
}
}
