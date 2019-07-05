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
[OpCode(4462)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PlayerTeamMemberOp
{
[Order(0)]
public long TeamUId {get; set; }
[Order(1)]
public char Operation {get; set; }
[Order(2)]
public int Member {get; set; }
}
}
