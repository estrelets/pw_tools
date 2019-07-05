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
[OpCode(4778)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleResult
{
[Order(0)]
public int PlayerBonus {get; set; }
[Order(1)]
public List<int> CountryBonus {get; set; }
[Order(2)]
public List<int> CountryDomainsCnt {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
