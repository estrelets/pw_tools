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
[OpCode(8123)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class RoleRelationReq
{
[Order(0)]
public long UserId {get; set; }
[Order(1)]
public long  RoleId {get; set; }
}
}
