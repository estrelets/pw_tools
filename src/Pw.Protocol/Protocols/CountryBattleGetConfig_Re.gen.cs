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
[OpCode(4773)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleGetConfig_Re
{
[Order(0)]
public int StartTimestamp {get; set; }
[Order(1)]
public int EndTimetamp {get; set; }
[Order(2)]
public int Bonus {get; set; }
[Order(3)]
public char IsBattleOpen {get; set; }
[Order(4)]
public char Domain2Datatype {get; set; }
[Order(5)]
public uint Domain2DatatTimestamp {get; set; }
[Order(6)]
public uint LocalsId {get; set; }
}
}
