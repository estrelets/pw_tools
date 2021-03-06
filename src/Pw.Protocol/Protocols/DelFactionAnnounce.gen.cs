﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4818)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DelFactionAnnounce
    {
        [Order(0)] public uint FactionId { get; set; }
    }
}
