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
[OpCode(3068)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PlayerAskForPresent
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int TargetRoleId {get; set; }
[Order(2)]
public int GoodsId {get; set; }
[Order(3)]
public int GoodsIndex {get; set; }
[Order(4)]
public int GoodsSlot {get; set; }
}
}
