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
[OpCode(8133)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class RoleActivation
{
[Order(0)]
public long  RoleId {get; set; }
[Order(1)]
public char Operation {get; set; }
}
}