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
[OpCode(4009)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class TradeMoveObj_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public uint TId {get; set; }
[Order(2)]
public int  RoleId {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
[Order(4)]
public char SrcPos {get; set; }
[Order(5)]
public int Count {get; set; }
[Order(6)]
public char DstPos {get; set; }
}
}
