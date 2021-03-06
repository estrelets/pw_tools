﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(390)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class IWebAutolockSet_Re
    {
        [Order(0)] public int TId { get; set; }

        [Order(1)] public int RetCode { get; set; }

        [Order(2)] public int UserId { get; set; }
    }
}
