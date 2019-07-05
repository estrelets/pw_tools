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
[OpCode(604)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GetSellList_Re
{
[Order(0)]
public uint LocalsId {get; set; }
[Order(1)]
public List<SellPointInfo> List {get; set; }
}
}
