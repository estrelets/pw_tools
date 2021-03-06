﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACUserCodeRes
    {
        [Order(0)] public short Count { get; set; }

        [Order(1)] public short Type { get; set; }

        [Order(2)] public ACCodeRes[] Res { get; set; }
    }
}
