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
[OpCode(4312)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class WebTradeAttendList
{
[Order(0)]
public int  RoleId {get; set; }
//1 sell 0 buy
[Order(1)]
public char Getsell {get; set; }
[Order(2)]
public uint Begin {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
