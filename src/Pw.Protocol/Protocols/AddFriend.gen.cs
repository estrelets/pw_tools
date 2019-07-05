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
[OpCode(202)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class AddFriend
{
[Order(0)]
public int SrcRoleId {get; set; }
[Order(1)]
public int DstRoleId {get; set; }
[Order(2)]
public byte[] DstName {get; set; }
[Order(3)]
public uint SrclsId {get; set; }
}
}
