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
[OpCode(153)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class QPAddCash_Re
{
[Order(0)]
public int LocalsId {get; set; }
[Order(1)]
public int Cash {get; set; }
[Order(2)]
public int CashAfterDiscount {get; set; }
[Order(3)]
public int MerchantId {get; set; }
[Order(4)]
public int RetCode {get; set; }
}
}
