﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class UserRoleCountRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int Count { get; set; }

        [Order(2)] public uint Rolelist { get; set; }
    }
}
