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
[OpCode(802)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AuctionBid
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint AuctionId {get; set; }
[Order(2)]
public uint Bidprice {get; set; }
[Order(3)]
public char Bin {get; set; }
// below parameter is provieded by gameserver
[Order(4)]
public uint LocalsId {get; set; }
[Order(5)]
public uint Money {get; set; }
}
}
