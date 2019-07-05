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
[OpCode(5003)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACRemoteCode
{
[Order(0)]
public int DstRoleId {get; set; }
[Order(1)]
public List<byte[]> Content {get; set; }
}
}
