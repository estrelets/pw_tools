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
[OpCode(4805)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionOPRequest_Re
{
[Order(0)]
public int RetCode {get; set; }
// operation type 
[Order(1)]
public int Optype {get; set; }
[Order(2)]
public int  RoleId {get; set; }
[Order(3)]
public int LinkId {get; set; }
[Order(4)]
public uint LocalsId {get; set; }
}
}
