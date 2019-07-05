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
[OpCode(207)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GetFriends_Re
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public GGroupInfo[] Groups {get; set; }
[Order(2)]
public GFriendInfo[] Friends {get; set; }
[Order(3)]
public Char[] Status {get; set; }
[Order(4)]
public uint LocalsId {get; set; }
}
}
