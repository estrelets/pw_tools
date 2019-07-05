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
[OpCode(962)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AutoTeamSetGoal
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public char GoalType {get; set; }
[Order(2)]
public char Op {get; set; }
[Order(3)]
public int GoalId {get; set; }
}
}
