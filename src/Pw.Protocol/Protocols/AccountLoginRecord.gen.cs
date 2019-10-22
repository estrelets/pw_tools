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
[OpCode(143)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AccountLoginRecord
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public int LoginTime {get; set; }
[Order(3)]
public int LoginIp {get; set; }
[Order(4)]
public int CurrentIp {get; set; }
}
}