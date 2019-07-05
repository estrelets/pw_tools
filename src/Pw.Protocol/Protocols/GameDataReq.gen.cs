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
[OpCode(8103)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GameDataReq
{
[Order(0)]
public int Dtype {get; set; }
[Order(1)]
public long  Id {get; set; }
}
}
