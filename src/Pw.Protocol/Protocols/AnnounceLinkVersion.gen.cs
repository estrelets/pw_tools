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
[OpCode(1130)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AnnounceLinkVersion
{
[Order(0)]
public uint Version {get; set; }
}
}
