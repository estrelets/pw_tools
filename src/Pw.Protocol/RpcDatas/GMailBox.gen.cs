﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMailBox
    {
        [Order(0)] public uint Timestamp { get; set; }

        [Order(1)] public uint Status { get; set; }

        [Order(2)] public GMail[] Mails { get; set; }
    }
}
