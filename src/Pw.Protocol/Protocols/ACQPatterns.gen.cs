﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5014)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQPatterns
    {
        [Order(0)] public ACQ Acq { get; set; }

        [Order(1)] public ACStackPattern[] Patterns { get; set; }
    }
}
