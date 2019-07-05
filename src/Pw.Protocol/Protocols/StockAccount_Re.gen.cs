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
[OpCode(408)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class StockAccount_Re
{
[Order(0)]
public int Cash {get; set; }
[Order(1)]
public int Money {get; set; }
[Order(2)]
public List<StockPrice> Prices {get; set; }
[Order(3)]
public char Locked {get; set; }
[Order(4)]
public uint LocalsId {get; set; }
}
}
