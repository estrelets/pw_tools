﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GSendAUMailRecord
    {
        [Order(0)] public int RId { get; set; }

        [Order(1)] public int SendmailTime { get; set; }
    }
}
