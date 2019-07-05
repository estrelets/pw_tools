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
[OpCode(380)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GMControlGame
{
[Order(0)]
public int XId {get; set; }
[Order(1)]
public int Worldtag {get; set; }
[Order(2)]
public byte[] Command {get; set; }
}
}
