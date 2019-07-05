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
[OpCode(3115)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class UniqueDataModifyRequire
{
[Order(0)]
public int Worldtag {get; set; }
[Order(1)]
public int Key {get; set; }
[Order(2)]
public int Vtype {get; set; }
[Order(3)]
public byte[] Value {get; set; }
[Order(4)]
public byte[] Oldvalue {get; set; }
[Order(5)]
public bool Exclusive {get; set; }
[Order(6)]
public bool Broadcast {get; set; }
[Order(7)]
public int Version {get; set; }
[Order(8)]
public bool Timeout {get; set; }
}
}
