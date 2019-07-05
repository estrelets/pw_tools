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
[OpCode(4313)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class WebTradeAttendList_Re
{
//1 sell 0 buy
[Order(0)]
public char Getsell {get; set; }
[Order(1)]
public uint End {get; set; }
[Order(2)]
public List<GWebTradeItem> Items {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
