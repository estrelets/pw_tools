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
[OpCode(389)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class IWebAutolockSet
{
[Order(0)]
public int TId {get; set; }
[Order(1)]
public int UserId {get; set; }
// -1: ÎÞÊ±ÏÞËø£¬0: ½âËø, ´óÓÚ0: Ëø¶¨µÄÃëÊý 
[Order(2)]
public int Locktime {get; set; }
}
}
