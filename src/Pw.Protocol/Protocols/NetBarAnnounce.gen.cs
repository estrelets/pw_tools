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
[OpCode(529)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class NetBarAnnounce
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public int AId {get; set; }
[Order(2)]
public int ZoneId {get; set; }
[Order(3)]
public int Title {get; set; }
[Order(4)]
public byte[]  RoleName {get; set; }
[Order(5)]
public int NetbarId {get; set; }
[Order(6)]
public int Netbarzone {get; set; }
[Order(7)]
public byte[] NetbarName {get; set; }
[Order(8)]
public int Netbarlevel {get; set; }
[Order(9)]
public byte[] Netbartitle {get; set; }
[Order(10)]
public byte[] Awardtype {get; set; }
[Order(11)]
public int Reserved1 {get; set; }
[Order(12)]
public int Reserved2 {get; set; }
}
}
