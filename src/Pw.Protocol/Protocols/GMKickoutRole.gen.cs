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
[OpCode(360)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GMKickoutRole
{
// roleid of game master 
[Order(0)]
public int GmRoleId {get; set; }
[Order(1)]
public int LocalsId {get; set; }
[Order(2)]
public int KickRoleId {get; set; }
[Order(3)]
public int ForbidTime {get; set; }
[Order(4)]
public byte[] Reason {get; set; }
}
}
