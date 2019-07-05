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
[OpCode(5032)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACAnswer
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int Qtype {get; set; }
[Order(2)]
public int Seq {get; set; }
[Order(3)]
public int Reserved {get; set; }
[Order(4)]
public int Answer {get; set; }
}
}
