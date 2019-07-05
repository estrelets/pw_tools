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
[OpCode(4471)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SNSRoleBriefUpdate
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public SNSRoleBrief Brief {get; set; }
[Order(2)]
public SNSRoleSkills Skills {get; set; }
[Order(3)]
public SNSRoleEquipment Equipment {get; set; }
[Order(4)]
public SNSRolePetCorral Petcorral {get; set; }
}
}
