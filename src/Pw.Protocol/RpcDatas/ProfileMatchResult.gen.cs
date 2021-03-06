﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ProfileMatchResult
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Level { get; set; }

        [Order(2)] public int Occupation { get; set; }

        [Order(3)] public byte Gender { get; set; }

        [Order(4)] public float Similarity { get; set; }
    }
}
