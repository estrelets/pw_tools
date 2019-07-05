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
[OpCode(401)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class StockCommission
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public char Isbuy {get; set; }
[Order(2)]
public int Price {get; set; }
[Order(3)]
public int Volume {get; set; }
[Order(4)]
public uint LocalsId {get; set; }
}
}
