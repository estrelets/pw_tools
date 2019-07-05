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
[OpCode(619)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FindSellPointInfo
{
[Order(0)]
public int StartId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public char Forward {get; set; }
}
}
