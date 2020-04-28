﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PutFactionFortressArg
    {
        [Order(0)] public int FactionId { get; set; }

        [Order(1)] public GFactionFortressInfo Info { get; set; }
    }
}
