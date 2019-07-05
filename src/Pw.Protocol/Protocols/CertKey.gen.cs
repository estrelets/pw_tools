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
[OpCode(547)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CertKey
{
[Order(0)]
public byte[] DKey1Encrypt {get; set; }
[Order(1)]
public byte[] DKey2Encrypt {get; set; }
[Order(2)]
public int Reserved1 {get; set; }
}
}
