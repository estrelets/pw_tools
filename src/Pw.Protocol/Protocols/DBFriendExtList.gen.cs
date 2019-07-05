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
[OpCode(231)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class DBFriendExtList
{
[Order(0)]
public int RId {get; set; }
[Order(1)]
public List<int> Roleidlist {get; set; }
}
}
