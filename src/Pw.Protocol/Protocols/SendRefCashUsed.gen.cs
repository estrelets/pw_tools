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
[OpCode(4902)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SendRefCashUsed
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int CashUsed {get; set; }
[Order(2)]
public int Level {get; set; }
}
}
