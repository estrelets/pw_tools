﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBUndoDeleteRoleRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public char GameserverId { get; set; }

        [Order(2)] public float Posx { get; set; }

        [Order(3)] public float Posy { get; set; }

        [Order(4)] public float Posz { get; set; }
    }
}
