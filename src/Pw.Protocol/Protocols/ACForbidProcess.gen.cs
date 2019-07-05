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
[OpCode(5015)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACForbidProcess
{
[Order(0)]
public Dictionary<int, string> ForbidProcess {get; set; }
}
}
