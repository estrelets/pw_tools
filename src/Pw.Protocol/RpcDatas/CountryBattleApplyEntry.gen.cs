﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleApplyEntry
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int MajorStrength { get; set; }

        [Order(2)] public int MinorStrength { get; set; }
    }
}
