﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CashSerialArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int ZoneId { get; set; }

        [Order(2)] public char Force { get; set; }
    }
}
