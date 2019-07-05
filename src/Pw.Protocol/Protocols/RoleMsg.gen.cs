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
[OpCode(8131)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class RoleMsg
{
[Order(0)]
public long Receiver {get; set; }
[Order(1)]
public RoleMsgBean Message {get; set; }
}
}
