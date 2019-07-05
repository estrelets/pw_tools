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
[OpCode(4769)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleSyncPlayerPos
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int Worldtag {get; set; }
[Order(2)]
public float Posx {get; set; }
[Order(3)]
public float Posy {get; set; }
[Order(4)]
public float Posz {get; set; }
[Order(5)]
public char IsCapital {get; set; }
}
}
