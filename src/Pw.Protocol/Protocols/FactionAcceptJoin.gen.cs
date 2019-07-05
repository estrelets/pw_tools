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
[OpCode(4812)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionAcceptJoin
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public uint FactionId {get; set; }
[Order(3)]
public int InvitedRoleId {get; set; }
}
}
