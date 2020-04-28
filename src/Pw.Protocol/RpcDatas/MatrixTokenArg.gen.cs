﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class MatrixTokenArg
    {
        [Order(0)] public byte[] Account { get; set; }

        [Order(1)] public byte[] Token { get; set; }

        [Order(2)] public int Loginip { get; set; }

        [Order(3)] public byte[] Challenge { get; set; }
    }
}
