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
[OpCode(4770)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CountryBattleGetPlayerLocation
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
}
}
