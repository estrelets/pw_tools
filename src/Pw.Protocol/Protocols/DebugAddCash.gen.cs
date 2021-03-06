﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(521)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DebugAddCash
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int Cash { get; set; }
    }
}
