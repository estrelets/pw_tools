﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PostDeleteFamilyArg
    {
        [Order(0)] public int ZoneId { get; set; }

        [Order(1)] public int FamilyId { get; set; }

        [Order(2)] public byte[] FamilyName { get; set; }
    }
}
