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
[OpCode(4219)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SysRecoveredObjMail
{
//  iweb¶¨Òå ÔÚreÖÐÖ±½Ó·µ»Ø¼´¿É 
[Order(0)]
public int TId {get; set; }
// NPC or Bidding-system ºÍSysSendMailÒ»Ñù iweb¶¼Ìî3 
[Order(1)]
public byte SysType {get; set; }
[Order(2)]
public int Receiver {get; set; }
[Order(3)]
public byte[] Title {get; set; }
// max context length is 400 bytes
[Order(4)]
public byte[] Context {get; set; }
[Order(5)]
public byte[] Obj {get; set; }
[Order(6)]
public byte[] Checksum {get; set; }
}
}
