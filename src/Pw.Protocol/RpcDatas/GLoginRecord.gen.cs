﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GLoginRecord
    {
        [Order(0)] public int LoginTime { get; set; }

        [Order(1)] public int LoginIp { get; set; }
    }
}
