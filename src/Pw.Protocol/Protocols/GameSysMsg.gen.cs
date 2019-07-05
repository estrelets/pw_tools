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
[OpCode(8102)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GameSysMsg
{
[Order(0)]
public int Mtype {get; set; }
[Order(1)]
public long Time {get; set; }
[Order(2)]
public int Emotiongroup {get; set; }
[Order(3)]
public byte[] Content {get; set; }
}
}
