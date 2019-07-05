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
[OpCode(4516)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionRename_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
[Order(3)]
public int RenamedRoleId {get; set; }
[Order(4)]
public byte[] NewName {get; set; }
// the role who do this operation 
[Order(5)]
public int Operater {get; set; }
}
}
