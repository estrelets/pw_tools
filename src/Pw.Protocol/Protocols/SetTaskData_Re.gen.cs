﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(114)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SetTaskData_Re
    {
        [Order(0)] public int RetCode { get; set; }
    }
}
