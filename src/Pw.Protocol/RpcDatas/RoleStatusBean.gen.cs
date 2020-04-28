﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleStatusBean
    {
        [Order(0)] public byte Status { get; set; }

        [Order(1)] public byte[] Extinfo { get; set; }
    }
}
