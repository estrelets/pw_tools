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
[OpCode(5002)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACWhoAmI
{
[Order(0)]
public int Clienttype {get; set; }
[Order(1)]
public int SubId {get; set; }
}
}
