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
[OpCode(8032)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PostExpire
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public long  RoleId {get; set; }
[Order(2)]
public long Sn {get; set; }
[Order(3)]
public long MessageId {get; set; }
[Order(4)]
public long Timestamp {get; set; }
[Order(5)]
public int Reserved1 {get; set; }
[Order(6)]
public int Reserved2 {get; set; }
}
}