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
[OpCode(78)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class S2CBroadcast
{
[Order(0)]
public byte[]  Data {get; set; }
}
}
