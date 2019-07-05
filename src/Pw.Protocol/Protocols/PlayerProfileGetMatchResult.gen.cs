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
[OpCode(954)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PlayerProfileGetMatchResult
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int MatchMode {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
}
}
