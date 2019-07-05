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
[OpCode(229)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ChatRoomList_Re
{
[Order(0)]
public ushort Sum {get; set; }
[Order(1)]
public GChatRoom[] Rooms {get; set; }
[Order(2)]
public char End {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
