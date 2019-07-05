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
[OpCode(364)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GMToggleChat
{
[Order(0)]
public int GmRoleId {get; set; }
[Order(1)]
public int LocalsId {get; set; }
[Order(2)]
public char Enable {get; set; }
}
}
