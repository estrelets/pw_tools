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
[OpCode(83)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class RoleList_Re
{
[Order(0)]
public int Result {get; set; }
[Order(1)]
public int Handle {get; set; }
[Order(2)]
public int UserId {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
[Order(4)]
public RoleInfo[] Rolelist {get; set; }
}
}
