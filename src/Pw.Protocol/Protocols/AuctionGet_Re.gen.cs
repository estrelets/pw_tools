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
[OpCode(809)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AuctionGet_Re
{
[Order(0)]
public ushort RetCode {get; set; }
[Order(1)]
public uint AuctionId {get; set; }
[Order(2)]
public GAuctionDetail Item {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
