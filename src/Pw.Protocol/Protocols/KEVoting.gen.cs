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
[OpCode(4858)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class KEVoting
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint ItemId {get; set; }
[Order(2)]
public int ItemPos {get; set; }
[Order(3)]
public int ItemNum {get; set; }
[Order(4)]
public int CandidateRoleId {get; set; }
[Order(5)]
public byte[] SyncData {get; set; }
}
}
