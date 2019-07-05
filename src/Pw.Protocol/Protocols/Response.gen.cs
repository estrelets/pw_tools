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
[OpCode(3)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class Response
{
[Order(0)]
public byte[] Identity {get; set; }
[Order(1)]
public byte[] ResponseProp {get; set; }
[Order(2)]
public char UseToken {get; set; }
[Order(3)]
public byte[] CliFingerprint {get; set; }
}
}
