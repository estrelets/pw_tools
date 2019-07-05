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
[OpCode(4759)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleConfigNotify
{
[Order(0)]
public GCountryCapital[] CountryCapitals {get; set; }
}
}
