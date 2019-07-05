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
[OpCode(106)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class DisconnectPlayer
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int ProviderLinkId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
[Order(3)]
public int GameId {get; set; }
}
}
