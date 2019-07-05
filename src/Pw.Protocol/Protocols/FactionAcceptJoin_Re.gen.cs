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
[OpCode(4505)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionAcceptJoin_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
[Order(3)]
public int Newmember {get; set; }
// the role who do this operation 
[Order(4)]
public int Operater {get; set; }
[Order(5)]
public uint FactionId {get; set; }
[Order(6)]
public int Level {get; set; }
[Order(7)]
public char Cls {get; set; }
[Order(8)]
public byte[]  Name {get; set; }
[Order(9)]
public int Reputation {get; set; }
[Order(10)]
public byte ReincarnTimes {get; set; }
[Order(11)]
public byte Gender {get; set; }
}
}
