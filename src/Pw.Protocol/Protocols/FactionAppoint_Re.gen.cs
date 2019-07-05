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
[OpCode(4510)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionAppoint_Re
{
[Order(0)]
public int RetCode {get; set; }
// receiver's roleid 
[Order(1)]
public int  RoleId {get; set; }
// reciever's localsid 
[Order(2)]
public uint LocalsId {get; set; }
// roleid of the member who is promoted or demoted 
[Order(3)]
public int DstRoleId {get; set; }
// new occupation of the member 
[Order(4)]
public char Newoccup {get; set; }
// the role who do this operation 
[Order(5)]
public int Operater {get; set; }
}
}
