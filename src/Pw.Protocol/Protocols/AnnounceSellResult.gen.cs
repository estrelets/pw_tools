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
[OpCode(610)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AnnounceSellResult
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
[Order(3)]
public int SellId {get; set; }
[Order(4)]
public int Seller {get; set; }
[Order(5)]
public int Point {get; set; }
[Order(6)]
public int Price {get; set; }
}
}
