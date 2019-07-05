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
[OpCode(917)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PShopManageFund_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int LocalsId {get; set; }
[Order(2)]
public uint Money {get; set; }
[Order(3)]
public uint Yinpiao {get; set; }
}
}
