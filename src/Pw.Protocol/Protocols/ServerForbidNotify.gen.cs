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
[OpCode(160)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ServerForbidNotify
{
[Order(0)]
public List<int> ForbidCtrlList {get; set; }
[Order(1)]
public List<int> ForbidItemList {get; set; }
[Order(2)]
public List<int> ForbidServiceList {get; set; }
[Order(3)]
public List<int> ForbidTaskList {get; set; }
[Order(4)]
public List<int> ForbidSkillList {get; set; }
}
}
