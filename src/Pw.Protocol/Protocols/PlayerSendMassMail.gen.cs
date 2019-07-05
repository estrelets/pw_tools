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
[OpCode(4217)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class PlayerSendMassMail
{
[Order(0)]
public char MassType {get; set; }
[Order(1)]
public int  RoleId {get; set; }
[Order(2)]
public uint LocalsId {get; set; }
[Order(3)]
public byte[] Title {get; set; }
// max context length is 400 bytes
[Order(4)]
public byte[] Context {get; set; }
[Order(5)]
public byte[] SenderName {get; set; }
// below parameter is provide by gameserver
[Order(6)]
public List<int> ReceiverList {get; set; }
[Order(7)]
public int CostObjId {get; set; }
[Order(8)]
public int CostObjNum {get; set; }
[Order(9)]
public int CostObjPos {get; set; }
[Order(10)]
public uint CostMoney {get; set; }
[Order(11)]
public byte[] SyncData {get; set; }
}
}
