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
[OpCode(4216)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GMailEndSync
{
[Order(0)]
public uint TId {get; set; }
[Order(1)]
public int RetCode {get; set; }
[Order(2)]
public int  RoleId {get; set; }
[Order(3)]
public GMailSyncData SyncData {get; set; }
}
}
