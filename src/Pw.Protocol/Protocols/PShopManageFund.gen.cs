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
[OpCode(916)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PShopManageFund
{
[Order(0)]
public int  RoleId {get; set; }
//0:´æÇ®;1:È¡Ç®
[Order(1)]
public int Optype {get; set; }
[Order(2)]
public uint Money {get; set; }
[Order(3)]
public uint Yinpiao {get; set; }
[Order(4)]
public byte[] SyncData {get; set; }
}
}
