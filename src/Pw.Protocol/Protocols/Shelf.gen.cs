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
[OpCode(8026)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class Shelf
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public long  RoleId {get; set; }
[Order(2)]
public long Sn {get; set; }
[Order(3)]
public int Price {get; set; }
// ½ö¹Ø×¢posttime(ÉÏ¼ÜÊ±¼ä),showperiodºÍsellperiod 
[Order(4)]
public TimeInfo Time {get; set; }
[Order(5)]
public long BuyerRoleId {get; set; }
[Order(6)]
public long MessageId {get; set; }
[Order(7)]
public long Timestamp {get; set; }
[Order(8)]
public int Reserved1 {get; set; }
[Order(9)]
public int Reserved2 {get; set; }
}
}
