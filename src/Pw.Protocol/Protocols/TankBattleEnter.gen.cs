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
[OpCode(4874)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class TankBattleEnter
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int BattleId {get; set; }
[Order(2)]
public int WorldTag {get; set; }
[Order(3)]
public int Model {get; set; }
}
}
