﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class UserArg
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public int LoginTime { get; set; }

        [Order(2)] public int LoginIp { get; set; }
    }
}
