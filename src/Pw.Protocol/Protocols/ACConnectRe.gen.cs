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
[OpCode(5004)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACConnectRe
{
[Order(0)]
public int AId {get; set; }
}
}
