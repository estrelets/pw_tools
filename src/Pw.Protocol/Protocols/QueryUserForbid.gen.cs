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
[OpCode(508)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class QueryUserForbid
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public char ZoneId {get; set; }
}
}
