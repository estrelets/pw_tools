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
[OpCode(770)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class DomainValidate
{
[Order(0)]
public byte[] Version {get; set; }
[Order(1)]
public byte[] Nonce {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
}
}
