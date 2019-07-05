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
[OpCode(807)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AuctionClose_Re
{
[Order(0)]
public ushort RetCode {get; set; }
[Order(1)]
public uint AuctionId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
}
}
