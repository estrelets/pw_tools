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
[OpCode(121)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AnnounceGM
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public Byte[] Auth {get; set; }
}
}
