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
[OpCode(4853)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class KEGetStatus_Re
{
[Order(0)]
public int Status {get; set; }
[Order(1)]
public KEKing King {get; set; }
[Order(2)]
public KECandidate[] CandidateList {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
