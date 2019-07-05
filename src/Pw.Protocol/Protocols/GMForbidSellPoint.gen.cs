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
[OpCode(378)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GMForbidSellPoint
{
[Order(0)]
public int GmRoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public int ForbidTime {get; set; }
[Order(3)]
public char Blon {get; set; }
}
}
