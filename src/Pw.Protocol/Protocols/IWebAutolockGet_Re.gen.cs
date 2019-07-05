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
[OpCode(388)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class IWebAutolockGet_Re
{
[Order(0)]
public int TId {get; set; }
[Order(1)]
public int RetCode {get; set; }
[Order(2)]
public int UserId {get; set; }
// Éè¶¨Ê±¼ä 
[Order(3)]
public int Settime {get; set; }
// -1: ÎÞÊ±ÏÞËø£¬0: Î´Ëø¶¨Ëø, ´óÓÚ0: Ëø¶¨µÄÃëÊý 
[Order(4)]
public int Locktime {get; set; }
}
}
