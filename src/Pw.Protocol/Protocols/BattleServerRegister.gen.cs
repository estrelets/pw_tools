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
[OpCode(856)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class BattleServerRegister
{
[Order(0)]
public int MapType {get; set; }
[Order(1)]
public int ServerId {get; set; }
[Order(2)]
public int WorldTag {get; set; }
}
}
