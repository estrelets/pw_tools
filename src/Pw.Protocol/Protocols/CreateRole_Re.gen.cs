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
[OpCode(85)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class CreateRole_Re
{
[Order(0)]
public int Result {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
//variable name="referrer_name"	type="Octets" default="Octets(0)" attr="ref"/
[Order(3)]
public RoleInfo Roleinfo {get; set; }
[Order(4)]
public int RefretCode {get; set; }
}
}
