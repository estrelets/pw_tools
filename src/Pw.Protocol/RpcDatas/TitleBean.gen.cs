﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TitleBean
    {
        [Order(0)] public int TitleId { get; set; }

        [Order(1)] public byte[] TitleName { get; set; }

        [Order(2)] public List<long> Members { get; set; }
    }
}
