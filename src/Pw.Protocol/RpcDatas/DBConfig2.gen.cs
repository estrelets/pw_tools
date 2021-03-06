﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBConfig2
    {
        [Order(0)] public uint IsCentralDb { get; set; }

        [Order(1)] public uint Reserve { get; set; }
    }
}
