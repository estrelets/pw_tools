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
[OpCode(8178)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class RoleLeaveVoiceChannel
{
[Order(0)]
public long UserId {get; set; }
[Order(1)]
public long  RoleId {get; set; }
[Order(2)]
public int ZoneId {get; set; }
[Order(3)]
public long Seq {get; set; }
[Order(4)]
public long Timestamp {get; set; }
}
}
