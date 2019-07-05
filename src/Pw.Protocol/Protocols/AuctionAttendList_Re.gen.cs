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
[OpCode(817)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AuctionAttendList_Re
{
[Order(0)]
public uint LocalsId {get; set; }
[Order(1)]
public int Gettype {get; set; }
[Order(2)]
public List<GAuctionItem> Items {get; set; }
}
}
