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
[OpCode(4859)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class KEVoting_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
}
}
