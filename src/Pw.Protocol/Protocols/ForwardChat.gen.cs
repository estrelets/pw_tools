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
[OpCode(8000)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ForwardChat
{
[Order(0)]
public int ZoneId {get; set; }
[Order(1)]
public int LineId {get; set; }
[Order(2)]
public int UserId {get; set; }
[Order(3)]
public int  RoleId {get; set; }
[Order(4)]
public byte[]  Name {get; set; }
[Order(5)]
public byte[] Msg {get; set; }
}
}
