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
[OpCode(8164)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionInfoUpdate
{
[Order(0)]
public FactionIDBean FactionId {get; set; }
[Order(1)]
public FactionInfoBean Factioninfo {get; set; }
[Order(2)]
public int Updateflag {get; set; }
}
}
