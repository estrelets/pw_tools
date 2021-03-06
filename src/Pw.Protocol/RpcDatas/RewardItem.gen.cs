﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RewardItem
    {
        [Order(0)] public int RewardTime { get; set; }

        [Order(1)] public int RewardBonus { get; set; }
    }
}
