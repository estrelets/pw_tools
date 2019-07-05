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
[OpCode(8126)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class RoleStatusResp
{
[Order(0)]
public long LocalrId {get; set; }
[Order(1)]
public Dictionary<long, RoleStatusBean> Rolestatus {get; set; }
}
}
