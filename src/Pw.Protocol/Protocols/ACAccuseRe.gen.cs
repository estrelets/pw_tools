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
[OpCode(5056)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACAccuseRe
{
[Order(0)]
public int ZoneId {get; set; }
[Order(1)]
public long  RoleId {get; set; }
[Order(2)]
public long AccId {get; set; }
[Order(3)]
public long AccusationRoleId {get; set; }
[Order(4)]
public long AccusationAccId {get; set; }
[Order(5)]
public int Result {get; set; }
}
}
