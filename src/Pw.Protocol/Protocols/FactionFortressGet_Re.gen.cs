﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4422)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionFortressGet_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public GFactionFortressBriefInfo Brief { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
