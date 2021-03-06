﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GTerritoryStore
    {
        [Order(0)] public List<GTerritoryDetail> Cities { get; set; }

        [Order(1)] public int Status { get; set; }

        [Order(2)] public int SpecialTime { get; set; }

        [Order(3)] public int Reserved2 { get; set; }

        [Order(4)] public int Reserved3 { get; set; }

        [Order(5)] public int Reserved4 { get; set; }
    }
}
