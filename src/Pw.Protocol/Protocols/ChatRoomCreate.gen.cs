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
[OpCode(219)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ChatRoomCreate
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public byte[] Subject {get; set; }
[Order(2)]
public ushort Capacity {get; set; }
[Order(3)]
public byte[] Password {get; set; }
[Order(4)]
public uint LocalsId {get; set; }
}
}
