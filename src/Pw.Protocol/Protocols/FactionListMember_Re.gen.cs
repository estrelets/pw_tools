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
[OpCode(4503)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionListMember_Re
{
[Order(0)]
public int Handle {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
[Order(3)]
public byte[] Proclaim {get; set; }
[Order(4)]
public FMemberInfo[] MemberList {get; set; }
[Order(5)]
public int[] OnlineList {get; set; }
}
}
