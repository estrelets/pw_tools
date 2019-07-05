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
[OpCode(113)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SetTaskData
{
[Order(0)]
public int TaskId {get; set; }
[Order(1)]
public byte[] TaskData {get; set; }
}
}
