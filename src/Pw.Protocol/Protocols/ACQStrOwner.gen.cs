﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5021)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQStrOwner
    {
        [Order(0)] public ACQ Acq { get; set; }

        [Order(1)] public IntData[] Owners { get; set; }
    }
}
