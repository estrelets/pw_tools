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
[OpCode(1110)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class SendDataAndIdentity
{
[Order(0)]
public int  RoleId {get; set; }
[Order(1)]
public int RemoteRoleId {get; set; }
[Order(2)]
public int UserId {get; set; }
[Order(3)]
public int SrcZoneId {get; set; }
[Order(4)]
public int Ip {get; set; }
[Order(5)]
public byte[] Iseckey {get; set; }
[Order(6)]
public byte[] Oseckey {get; set; }
[Order(7)]
public byte[] Account {get; set; }
[Order(8)]
public byte[] Random {get; set; }
//0:Õý³£µÇÂ½Âß¼­ 1:Ô­·þµ½¿ç·þ 2:¿ç·þµ½Ô­·þ 3:Ö±½ÓµÇÂ¼¿ç·þ·þÎñÆ÷
[Order(9)]
public char Flag {get; set; }
[Order(10)]
public CrossPlayerData  Data {get; set; }
[Order(11)]
public int DataTimestamp {get; set; }
[Order(12)]
public int Logintime {get; set; }
[Order(13)]
public char AuIsgm {get; set; }
[Order(14)]
public int AuFunc {get; set; }
[Order(15)]
public int AuFuncparm {get; set; }
[Order(16)]
public Byte[] Auth {get; set; }
[Order(17)]
public char Usbbind {get; set; }
[Order(18)]
public int RewardMask {get; set; }
[Order(19)]
public GRoleForbid ForbidTalk {get; set; }
}
}
