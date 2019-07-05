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
[OpCode(4508)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionChangProclaim_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
// the role who do this operation 
[Order(3)]
public int Operater {get; set; }
[Order(4)]
public byte[] Proclaim {get; set; }
}
}
