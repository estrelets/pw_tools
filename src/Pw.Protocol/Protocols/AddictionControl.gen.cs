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
[OpCode(556)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AddictionControl
{
[Order(0)]
public int ZoneId {get; set; }
[Order(1)]
public int UserId {get; set; }
[Order(2)]
public int Rate {get; set; }
[Order(3)]
public int Msg {get; set; }
[Order(4)]
public List<GPair>  Data {get; set; }
}
}
