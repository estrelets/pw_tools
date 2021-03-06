﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RawKeyValue
    {
        [Order(0)] public byte[] Key { get; set; }

        [Order(1)] public byte[] Value { get; set; }
    }
}
