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
[OpCode(527)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AnnounceZoneid3
{
[Order(0)]
public int ZoneId {get; set; }
[Order(1)]
public int AId {get; set; }
[Order(2)]
public char Blreset {get; set; }
[Order(3)]
public int Ip1 {get; set; }
[Order(4)]
public int Ip2 {get; set; }
[Order(5)]
public int Ip3 {get; set; }
[Order(6)]
public int GetAuVersion {get; set; }
[Order(7)]
public int Reserved {get; set; }
}
}
