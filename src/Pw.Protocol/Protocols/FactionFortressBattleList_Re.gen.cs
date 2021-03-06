﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4420)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionFortressBattleList_Re
    {
        [Order(0)] public int Status { get; set; }

        [Order(1)] public List<GFactionFortressBattleInfo> List { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
