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
[OpCode(4854)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class KECandidateApply
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint ItemId {get; set; }
[Order(2)]
public int ItemNum {get; set; }
[Order(3)]
public byte[] SyncData {get; set; }
}
}
