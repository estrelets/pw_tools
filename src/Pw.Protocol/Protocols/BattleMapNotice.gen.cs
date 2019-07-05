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
[OpCode(870)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class BattleMapNotice
{
[Order(0)]
public int Status {get; set; }
[Order(1)]
public List<GCity> Cities {get; set; }
}
}
