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
[OpCode(161)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PlayerAccuse
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int DstRoleId {get; set; }
[Order(2)]
public byte[] Content {get; set; }
}
}
