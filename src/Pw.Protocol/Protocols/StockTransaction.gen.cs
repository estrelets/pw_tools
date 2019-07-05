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
[OpCode(402)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class StockTransaction
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public char Withdraw {get; set; }
[Order(2)]
public int Cash {get; set; }
[Order(3)]
public int Money {get; set; }
[Order(4)]
public uint LocalsId {get; set; }
[Order(5)]
public GMailSyncData SyncData {get; set; }
}
}
