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
[OpCode(107)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GetPlayerBriefInfo
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public int[] Playerlist {get; set; }
[Order(3)]
public byte Reason {get; set; }
}
}
