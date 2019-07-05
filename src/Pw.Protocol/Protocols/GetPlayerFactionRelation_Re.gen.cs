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
[OpCode(4822)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GetPlayerFactionRelation_Re
{
[Order(0)]
public int FactionId {get; set; }
[Order(1)]
public List<int> RoleidList {get; set; }
[Order(2)]
public List<int> Alliance {get; set; }
[Order(3)]
public List<int> Hostile {get; set; }
}
}
