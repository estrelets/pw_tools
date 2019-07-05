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
[OpCode(602)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SellPoint_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public SellPointInfo Info {get; set; }
}
}
