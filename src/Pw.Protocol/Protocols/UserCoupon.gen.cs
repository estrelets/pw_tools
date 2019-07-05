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
[OpCode(138)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class UserCoupon
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
}
}
