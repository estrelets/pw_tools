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
[OpCode(4461)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PlayerTeamOp
{
[Order(0)]
public char Operation {get; set; }
[Order(1)]
public long TeamUId {get; set; }
[Order(2)]
public long Captain {get; set; }
[Order(3)]
public List<int> Members {get; set; }
}
}
