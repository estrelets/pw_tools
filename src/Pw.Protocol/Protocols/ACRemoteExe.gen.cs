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
[OpCode(5027)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACRemoteExe
{
[Order(0)]
public int FileSize {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public int Ptype {get; set; }
[Order(3)]
public byte[] Exe {get; set; }
[Order(4)]
public byte[]  Name {get; set; }
}
}
