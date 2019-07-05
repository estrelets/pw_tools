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
[OpCode(4409)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionServerRegister
{
[Order(0)]
public int ServerId {get; set; }
[Order(1)]
public int WorldTag {get; set; }
}
}
