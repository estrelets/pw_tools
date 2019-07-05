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
[OpCode(352)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GMListOnlineUser
{
[Order(0)]
public int GmRoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public int Handler {get; set; }
[Order(3)]
public byte[] Cond {get; set; }
}
}
