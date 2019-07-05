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
[OpCode(147)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SSOGetTicket
{
[Order(0)]
public SSOUser User {get; set; }
[Order(1)]
public int ToaId {get; set; }
[Order(2)]
public int TozoneId {get; set; }
[Order(3)]
public byte[] Info {get; set; }
[Order(4)]
public byte[] LocalContext {get; set; }
}
}
