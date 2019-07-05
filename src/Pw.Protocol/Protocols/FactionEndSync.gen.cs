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
[OpCode(4810)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionEndSync
{
// transaction id
[Order(0)]
public uint TId {get; set; }
// role that is in the transcation
[Order(1)]
public int  RoleId {get; set; }
// data that is nessessary and need sync
[Order(2)]
public FactionOPSyncInfo SyncData {get; set; }
}
}
