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
[OpCode(5017)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACCPUInfo
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public Dictionary<List<int>, int> CpuInfo {get; set; }
}
}
