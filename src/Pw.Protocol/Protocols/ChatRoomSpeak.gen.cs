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
[OpCode(227)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ChatRoomSpeak
{
[Order(0)]
public ushort RoomId {get; set; }
[Order(1)]
public byte Emotion {get; set; }
[Order(2)]
public byte[] Message {get; set; }
[Order(3)]
public int Src {get; set; }
[Order(4)]
public int Dst {get; set; }
[Order(5)]
public uint LocalsId {get; set; }
}
}
