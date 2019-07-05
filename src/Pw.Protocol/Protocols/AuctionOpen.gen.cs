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
[OpCode(800)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AuctionOpen
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public ushort Category {get; set; }
[Order(3)]
public int ItemId {get; set; }
[Order(4)]
public int ItemPos {get; set; }
[Order(5)]
public int ItemNum {get; set; }
[Order(6)]
public uint Baseprice {get; set; }
[Order(7)]
public uint Binprice {get; set; }
// below parameter is provide by gameserver
[Order(8)]
public int ElapseTime {get; set; }
[Order(9)]
public uint Deposit {get; set; }
[Order(10)]
public byte[] SyncData {get; set; }
}
}
