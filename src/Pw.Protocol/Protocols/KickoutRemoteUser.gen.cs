﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1120)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class KickoutRemoteUser
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int ZoneId { get; set; }
    }
}
