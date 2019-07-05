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
[OpCode(4521)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionRemoveRelationApply_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public int DstFId {get; set; }
[Order(2)]
public char Force {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
