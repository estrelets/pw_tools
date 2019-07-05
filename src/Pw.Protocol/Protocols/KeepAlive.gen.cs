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
[OpCode(90)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class KeepAlive
{
[Order(0)]
public char  Code {get; set; }
}
}
