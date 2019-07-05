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
[OpCode(4308)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class WebTradeList
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint Category {get; set; }
[Order(2)]
public uint Begin {get; set; }
[Order(3)]
public char Reverse {get; set; }
[Order(4)]
public uint LocalsId {get; set; }
}
}
