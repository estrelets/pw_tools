﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4210)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PreserveMail
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public byte MailId { get; set; }

// whether preserve mail
        [Order(3)] public byte Blpreserve { get; set; }
    }
}
