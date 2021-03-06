﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GCountryBattleDomain
    {
        [Order(0)] public int Id { get; set; }

        [Order(1)] public char Owner { get; set; }

        [Order(2)] public char Challenger { get; set; }

        [Order(3)] public char Status { get; set; }

        [Order(4)] public char BattleConfigMask { get; set; }

        [Order(5)] public int Time { get; set; }

        [Order(6)] public List<int> CountryPlayercnt { get; set; }
    }
}
