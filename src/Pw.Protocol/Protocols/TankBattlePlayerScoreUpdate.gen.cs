﻿using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.RpcDatas;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
[OpCode(4880)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class TankBattlePlayerScoreUpdate
{
[Order(0)]
public int BattleId {get; set; }
[Order(1)]
public int WorldTag {get; set; }
[Order(2)]
public TankBattlePlayerScoreInfo[] PlayerScoRes {get; set; }
}
}
