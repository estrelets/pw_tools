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
[OpCode(8052)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class BillingConfirm
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public int ItemId {get; set; }
//item ÊýÁ¿
[Order(2)]
public int Itemcnt {get; set; }
[Order(3)]
public byte[] ItemName {get; set; }
[Order(4)]
public int Itemexpire {get; set; }
//item µ¥¼Û
[Order(5)]
public int Itemprice {get; set; }
[Order(6)]
public int Loginip {get; set; }
}
}
