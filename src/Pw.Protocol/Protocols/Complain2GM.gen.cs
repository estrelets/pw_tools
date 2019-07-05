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
[OpCode(370)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class Complain2GM
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public byte[]  RoleName {get; set; }
[Order(3)]
public byte[] CompRoleName {get; set; }
[Order(4)]
public int ZoneId {get; set; }
[Order(5)]
public byte[] Mapzone {get; set; }
[Order(6)]
public float Posx {get; set; }
[Order(7)]
public float Posy {get; set; }
[Order(8)]
public float Posz {get; set; }
[Order(9)]
public byte[] Content {get; set; }
}
}
