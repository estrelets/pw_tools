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
[OpCode(5005)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACReloadConfig
{
[Order(0)]
public int ReloadType {get; set; }
[Order(1)]
public byte[] Config {get; set; }
}
}
