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
[OpCode(125)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FaceModify
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int TicketId {get; set; }
[Order(2)]
public int TicketPos {get; set; }
}
}
