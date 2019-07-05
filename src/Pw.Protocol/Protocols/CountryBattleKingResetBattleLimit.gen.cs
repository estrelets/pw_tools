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
[OpCode(4783)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleKingResetBattleLimit
{
[Order(0)]
public int KingRoleId {get; set; }
[Order(1)]
public int DomainId {get; set; }
[Order(2)]
public char Op {get; set; }
[Order(3)]
public List<GCountryBattleLimit> Limit {get; set; }
}
}
