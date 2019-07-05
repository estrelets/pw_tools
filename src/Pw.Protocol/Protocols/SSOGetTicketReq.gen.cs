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
[OpCode(8016)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SSOGetTicketReq
{
[Order(0)]
public SSOUser User {get; set; }
[Order(1)]
public int Loginip {get; set; }
[Order(2)]
public int ToaId {get; set; }
[Order(3)]
public int TozoneId {get; set; }
[Order(4)]
public byte[] Info {get; set; }
[Order(5)]
public byte[] LocalContext {get; set; }
[Order(6)]
public byte[] Reserved {get; set; }
}
}
