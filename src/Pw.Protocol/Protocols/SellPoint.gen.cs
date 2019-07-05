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
[OpCode(601)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SellPoint
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
// 1 point = 1 second 
[Order(2)]
public int Point {get; set; }
[Order(3)]
public int Price {get; set; }
}
}
