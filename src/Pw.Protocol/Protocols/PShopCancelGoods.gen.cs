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
[OpCode(906)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PShopCancelGoods
{
[Order(0)]
public int  RoleId {get; set; }
//0:È¡Ïû³öÊÛ;1:È¡ÏûÊÕ¹º
[Order(1)]
public int Canceltype {get; set; }
[Order(2)]
public int Pos {get; set; }
}
}
