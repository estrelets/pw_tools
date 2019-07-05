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
[OpCode(120)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ChatBroadCast
{
[Order(0)]
public byte Channel {get; set; }
[Order(1)]
public byte Emotion {get; set; }
[Order(2)]
public int SrcRoleId {get; set; }
[Order(3)]
public byte[] Msg {get; set; }
[Order(4)]
public byte[]  Data {get; set; }
}
}
