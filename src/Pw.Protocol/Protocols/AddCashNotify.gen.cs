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
[OpCode(142)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AddCashNotify
{
[Order(0)]
public int  RoleId {get; set; }
}
}