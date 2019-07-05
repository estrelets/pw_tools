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
[OpCode(1122)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GetRemoteRoleInfo
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int RemoteRoleId {get; set; }
[Order(2)]
public int UserId {get; set; }
[Order(3)]
public int ZoneId {get; set; }
}
}
