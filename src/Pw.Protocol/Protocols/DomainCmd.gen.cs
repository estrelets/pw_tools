﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(771)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DomainCmd
    {
        [Order(0)] public byte[] Cmd { get; set; }

        [Order(1)] public byte[] Stamp { get; set; }

        [Order(2)] public int Length { get; set; }

        [Order(3)] public char Dest { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
