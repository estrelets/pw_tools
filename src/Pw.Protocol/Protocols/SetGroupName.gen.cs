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
[OpCode(208)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SetGroupName
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public char GId {get; set; }
[Order(2)]
public byte[]  Name {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
