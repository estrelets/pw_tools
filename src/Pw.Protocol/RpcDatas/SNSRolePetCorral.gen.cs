﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SNSRolePetCorral
    {
        [Order(0)] public uint Crc { get; set; }

        [Order(1)] public byte[] Petcorral { get; set; }
    }
}
