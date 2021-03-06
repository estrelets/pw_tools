﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GFactionFortressInfo2
    {
        [Order(0)] public int Health { get; set; }

        [Order(1)] public int OffenseFaction { get; set; }

        [Order(2)] public int OffenseStarttime { get; set; }

        [Order(3)] public int OffenseEndtime { get; set; }

        //ÉÏÏÞ32¸ö
        [Order(4)] public List<int> ChallengeList { get; set; }

        [Order(5)] public int Reserved1 { get; set; }

        [Order(6)] public int Reserved2 { get; set; }

        [Order(7)] public int Reserved3 { get; set; }
    }
}
