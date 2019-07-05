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
[OpCode(144)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class UserAddCash
{
[Order(0)]
public int UserId {get; set; }
[Order(1)]
public byte[] Cardnum {get; set; }
[Order(2)]
public byte[] Cardpasswd {get; set; }
[Order(3)]
public uint LocalsId {get; set; }
}
}
