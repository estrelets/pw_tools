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
[OpCode(140)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class UserCouponExchange
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public int CouponNumber {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
}
}
