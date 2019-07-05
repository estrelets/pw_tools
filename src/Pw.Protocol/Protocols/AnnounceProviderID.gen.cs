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
[OpCode(73)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AnnounceProviderID
{
[Order(0)]
public int  Id {get; set; }
[Order(1)]
public float Left {get; set; }
[Order(2)]
public float Right {get; set; }
[Order(3)]
public float Top {get; set; }
[Order(4)]
public float Bottom {get; set; }
[Order(5)]
public int Worldtag {get; set; }
[Order(6)]
public byte[] Edition {get; set; }
}
}
