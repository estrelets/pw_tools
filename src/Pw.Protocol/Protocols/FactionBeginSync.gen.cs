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
[OpCode(4808)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionBeginSync
{
// transaction id
[Order(0)]
public uint TId {get; set; }
// role that is in the transcation
[Order(1)]
public int  RoleId {get; set; }
}
}
