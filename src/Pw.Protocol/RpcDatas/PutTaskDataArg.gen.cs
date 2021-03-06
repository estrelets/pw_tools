﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PutTaskDataArg
    {
        [Order(0)] public int TaskId { get; set; }

        [Order(1)] public byte[] TaskData { get; set; }
    }
}
