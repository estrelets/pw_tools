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
[OpCode(4785)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleGetBattleLimit_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int DomainId {get; set; }
[Order(2)]
public List<GCountryBattleLimit> Limit {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
