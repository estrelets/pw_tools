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
[OpCode(853)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class BattleChallenge_Re
{
[Order(0)]
public ushort RetCode {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public short  Id {get; set; }
[Order(3)]
public uint Deposit {get; set; }
[Order(4)]
public uint Maxbonus {get; set; }
[Order(5)]
public uint Challenger {get; set; }
[Order(6)]
public uint CutoffTime {get; set; }
[Order(7)]
public uint LocalsId {get; set; }
}
}
