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
[OpCode(5016)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class ACQPlatformInfo
{
[Order(0)]
public ACQ Acq {get; set; }
[Order(1)]
public ACPlatformInfo[] PlatformInfo {get; set; }
[Order(2)]
public ACCPUInfo[] CpuInfo {get; set; }
[Order(3)]
public ACMemInfo[] MemInfo {get; set; }
[Order(4)]
public ACAdapterInfo[] AdapterInfo {get; set; }
}
}
