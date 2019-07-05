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
[OpCode(5013)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACCheaters
{
[Order(0)]
public Dictionary<int, List<KeyValuePair<int, KeyValuePair<int, int>>>> Cheaters {get; set; }
}
}
