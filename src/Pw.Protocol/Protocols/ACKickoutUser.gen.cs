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
[OpCode(5035)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACKickoutUser
{
[Order(0)]
public int GmuserId {get; set; }
// 0=userid, 1=roleid
[Order(1)]
public int Idtype {get; set; }
[Order(2)]
public int UserId {get; set; }
[Order(3)]
public int ForbidTime {get; set; }
[Order(4)]
public byte[] Reason {get; set; }
}
}
