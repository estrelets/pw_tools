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
[OpCode(4823)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionCongregateRequest
{
[Order(0)]
public int FactionId {get; set; }
[Order(1)]
public int Sponsor {get; set; }
[Order(2)]
public byte[]  Data {get; set; }
[Order(3)]
public List<int> Member {get; set; }
}
}
