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
[OpCode(9001)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class BillingRequest
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public int Request {get; set; }
[Order(2)]
public int Result {get; set; }
[Order(3)]
public int ItemId {get; set; }
[Order(4)]
public int Itemnum {get; set; }
[Order(5)]
public int Timeout {get; set; }
[Order(6)]
public int Amount {get; set; }
[Order(7)]
public byte[] MenuId {get; set; }
[Order(8)]
public byte[] Bxtxno {get; set; }
[Order(9)]
public byte[] Agtxno {get; set; }
}
}
