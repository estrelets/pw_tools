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
[OpCode(4206)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class GetMailAttachObj
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public uint LocalsId {get; set; }
[Order(2)]
public byte MailId {get; set; }
// below parameter is provide by gameserver
[Order(3)]
public byte ObjType {get; set; }
[Order(4)]
public byte[] SyncData {get; set; }
}
}
