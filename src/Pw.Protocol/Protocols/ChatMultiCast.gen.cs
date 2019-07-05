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
[OpCode(81)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ChatMultiCast
{
[Order(0)]
public Player[] Playerlist {get; set; }
[Order(1)]
public byte Channel {get; set; }
[Order(2)]
public byte Emotion {get; set; }
[Order(3)]
public int SrcRoleId {get; set; }
[Order(4)]
public byte[] Msg {get; set; }
[Order(5)]
public byte[]  Data {get; set; }
[Order(6)]
public int Srclevel {get; set; }
}
}
