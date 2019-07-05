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
[OpCode(211)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SetFriendGroup_Re
{
[Order(0)]
public char RetCode {get; set; }
[Order(1)]
public char GId {get; set; }
[Order(2)]
public int  RoleId {get; set; }
[Order(3)]
public int FriendId {get; set; }
[Order(4)]
public uint LocalsId {get; set; }
}
}
