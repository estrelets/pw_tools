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
[OpCode(4506)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionExpel_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
[Order(3)]
public uint ExpelRoleId {get; set; }
// the role who do this operation 
[Order(4)]
public int Operater {get; set; }
}
}
