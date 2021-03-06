﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5022)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQMouseInfo
    {
        [Order(0)] public ACQ Acq { get; set; }

        [Order(1)] public ACMouseInfo[] MouseInfo { get; set; }
    }
}
