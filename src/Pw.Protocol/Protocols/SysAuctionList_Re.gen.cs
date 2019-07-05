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
[OpCode(4352)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SysAuctionList_Re
{
[Order(0)]
public List<GSysAuctionItem> Items {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
}
}
