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
[OpCode(4053)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class TouchPointCost_Re
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public long OrderId {get; set; }
[Order(2)]
public uint Cost {get; set; }
[Order(3)]
public long Income {get; set; }
[Order(4)]
public long Remain {get; set; }
[Order(5)]
public int RetCode {get; set; }
}
}
