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
[OpCode(4309)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class WebTradeList_Re
{
[Order(0)]
public uint Category {get; set; }
[Order(1)]
public uint End {get; set; }
[Order(2)]
public List<GWebTradeItem> Items {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
