﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GRewardStore
    {
        [Order(0)] public int ConsumePoints { get; set; }

        [Order(1)] public int BonusReward { get; set; }

        [Order(2)] public GRewardItem[] Rewardlist { get; set; }

        [Order(3)] public int Reserved1 { get; set; }

        [Order(4)] public int Reserved2 { get; set; }

        [Order(5)] public int Reserved3 { get; set; }

        [Order(6)] public int Reserved4 { get; set; }
    }
}
