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
[OpCode(4755)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleOnlineNotice
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int CountryId {get; set; }
[Order(2)]
public int Worldtag {get; set; }
[Order(3)]
public int MinorStrength {get; set; }
[Order(4)]
public char IsKing {get; set; }
}
}
