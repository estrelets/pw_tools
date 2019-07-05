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
[OpCode(221)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ChatRoomInvite
{
[Order(0)]
public ushort RoomId {get; set; }
[Order(1)]
public int Invitee {get; set; }
[Order(2)]
public int Inviter {get; set; }
[Order(3)]
public byte[]  Name {get; set; }
[Order(4)]
public byte[] Subject {get; set; }
[Order(5)]
public ushort Capacity {get; set; }
[Order(6)]
public ushort Number {get; set; }
[Order(7)]
public byte[] Password {get; set; }
[Order(8)]
public uint LocalsId {get; set; }
}
}
