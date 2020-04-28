﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetMaxOnlineNumRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int Maxnum { get; set; }

        [Order(2)] public int FakeMaxnum { get; set; }

        [Order(3)] public int Curnum { get; set; }
    }
}
