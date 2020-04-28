﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(365)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMToggleChat_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int GmRoleId { get; set; }

        [Order(2)] public int LocalsId { get; set; }

        [Order(3)] public char Enable { get; set; }
    }
}
