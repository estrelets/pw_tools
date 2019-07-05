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
[OpCode(1117)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class RemoteLoginQuery
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public int RemoteRoleId {get; set; }
[Order(3)]
public int UserId {get; set; }
//0:Õý³£µÇÂ½Âß¼­ 1:Ô­·þµ½¿ç·þ 2:¿ç·þµ½Ô­·þ 3:Ö±½ÓµÇÂ¼¿ç·þ·þÎñÆ÷
[Order(4)]
public char Flag {get; set; }
[Order(5)]
public int RemoteZoneId {get; set; }
}
}
