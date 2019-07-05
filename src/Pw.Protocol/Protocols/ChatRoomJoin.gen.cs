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
[OpCode(223)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ChatRoomJoin
{
[Order(0)]
public ushort RoomId {get; set; }
[Order(1)]
public int OwnerId {get; set; }
[Order(2)]
public byte[] OwnerName {get; set; }
[Order(3)]
public uint  RoleId {get; set; }
[Order(4)]
public byte[] Password {get; set; }
[Order(5)]
public uint LocalsId {get; set; }
}
}
