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
[OpCode(367)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GMForbidRole_Re
{
[Order(0)]
public int RetCode {get; set; }
[Order(1)]
public byte FbdType {get; set; }
[Order(2)]
public int DstRoleId {get; set; }
[Order(3)]
public int ForbidTime {get; set; }
}
}