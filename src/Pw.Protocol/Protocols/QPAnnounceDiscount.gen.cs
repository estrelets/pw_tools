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
[OpCode(149)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class QPAnnounceDiscount
{
[Order(0)]
public int LocalsId {get; set; }
// ¿ì½ÝÖ§¸¶µÄÕÛ¿Û 
[Order(1)]
public QPDiscountInfo[] Discount {get; set; }
}
}
