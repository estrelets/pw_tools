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
[OpCode(8064)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class DiscountAnnounce
{
// ¿ì½ÝÖ§¸¶µÄÕÛ¿Û 
[Order(0)]
public MerchantDiscount[] Discount {get; set; }
[Order(1)]
public int Reserved1 {get; set; }
[Order(2)]
public byte[] Reserved2 {get; set; }
}
}
