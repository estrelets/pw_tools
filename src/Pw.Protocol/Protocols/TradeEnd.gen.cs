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
[OpCode(4016)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class TradeEnd
{
[Order(0)]
public uint TId {get; set; }
[Order(1)]
public char Cause {get; set; }
[Order(2)]
public int  RoleId {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
