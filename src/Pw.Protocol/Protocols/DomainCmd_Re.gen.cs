﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(772)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DomainCmd_Re
    {
        [Order(0)] public byte[] Res { get; set; }

        [Order(1)] public int Serial { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
