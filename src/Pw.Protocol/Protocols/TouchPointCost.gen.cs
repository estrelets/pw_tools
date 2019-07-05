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
[OpCode(4052)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class TouchPointCost
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public long OrderId {get; set; }
[Order(2)]
public uint Cost {get; set; }
}
}
