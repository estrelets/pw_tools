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
[OpCode(519)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class VerifyMaster
{
[Order(0)]
public int ZoneId {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public byte[]  RoleName {get; set; }
[Order(3)]
public byte[] Faction {get; set; }
}
}
