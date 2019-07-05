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
[OpCode(101)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SetCustomData_Re
{
[Order(0)]
public int Result {get; set; }
[Order(1)]
public uint Crc {get; set; }
[Order(2)]
public int  RoleId {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
