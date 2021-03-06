﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1115)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SendDataAndIdentity_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int RemoteRoleId { get; set; }

        [Order(3)] public int UserId { get; set; }

//0:Õý³£µÇÂ½Âß¼­ 1:Ô­·þµ½¿ç·þ 2:¿ç·þµ½Ô­·þ 3:Ö±½ÓµÇÂ¼¿ç·þ·þÎñÆ÷
        [Order(4)] public char Flag { get; set; }

        [Order(5)] public int DstZoneId { get; set; }

        [Order(6)] public byte[] RoleinfoPack { get; set; }

//ÓÃÀ´ÅÐ¶Ï¿ç·þroleidÊÇ·ñÖØÐÂ·ÖÅä£¬½öÏÞÓÚflag==1:Ô­·þµ½¿ç·þµÄÂß¼­Ê¹ÓÃ
        [Order(7)] public char IsRemoteRoleidChanged { get; set; }
    }
}
