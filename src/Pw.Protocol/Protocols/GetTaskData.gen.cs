﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(111)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetTaskData
    {
        [Order(0)] public int TaskId { get; set; }

        [Order(1)] public int PlayerId { get; set; }

        [Order(2)] public byte[] Env { get; set; }
    }
}
