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
[OpCode(4764)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleStart_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int BattleId {get; set; }
[Order(2)]
public int WorldTag {get; set; }
[Order(3)]
public uint Defender {get; set; }
[Order(4)]
public uint Attacker {get; set; }
}
}
