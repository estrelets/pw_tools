﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5008)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQLogInfo
    {
        [Order(0)] public ACQ Acq { get; set; }

        [Order(1)] public ACLogInfo[] Logs { get; set; }
    }
}
