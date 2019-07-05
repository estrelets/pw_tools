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
[OpCode(8054)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class BillingCancel
{
[Order(0)]
public int UserId {get; set; }
//billing system Éú³É¶©µ¥ºÅ
[Order(1)]
public byte[] Chargeno {get; set; }
}
}
