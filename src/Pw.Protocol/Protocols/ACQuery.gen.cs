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
[OpCode(5007)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACQuery
{
[Order(0)]
public ACQ Acq {get; set; }
[Order(1)]
public IntOctets[] Params {get; set; }
}
}
