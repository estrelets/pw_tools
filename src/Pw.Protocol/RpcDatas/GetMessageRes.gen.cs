﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetMessageRes
    {
        [Order(0)] public char RetCode { get; set; }

        [Order(1)] public Message[] Messages { get; set; }
    }
}
