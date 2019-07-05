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
[OpCode(8165)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionMsg
{
[Order(0)]
public FactionIDBean FactionId {get; set; }
[Order(1)]
public RoleMsgBean Message {get; set; }
}
}
