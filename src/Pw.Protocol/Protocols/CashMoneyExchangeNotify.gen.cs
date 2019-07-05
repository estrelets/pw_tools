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
[OpCode(157)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CashMoneyExchangeNotify
{
[Order(0)]
public char Open {get; set; }
[Order(1)]
public int Rate {get; set; }
}
}
