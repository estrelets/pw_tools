﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(233)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SendAUMail
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int FriendId { get; set; }

        [Order(3)] public int MailTemplateId { get; set; }
    }
}
