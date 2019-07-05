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
[OpCode(4525)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class FactionRelationRecvReply
{
[Order(0)]
public int PreApplyType {get; set; }
[Order(1)]
public char Agree {get; set; }
[Order(2)]
public int SrcFId {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
