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
[OpCode(8162)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionInfoResp
{
[Order(0)]
public long LocaluId {get; set; }
[Order(1)]
public FactionIDBean FactionId {get; set; }
[Order(2)]
public FactionInfoBean Factioninfo {get; set; }
[Order(3)]
public FactionTitleBean[] Members {get; set; }
[Order(4)]
public byte[] Forbidlist {get; set; }
}
}
