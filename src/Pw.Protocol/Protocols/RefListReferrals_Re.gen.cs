﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4905)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RefListReferrals_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int StartIndex { get; set; }

        [Order(3)] public int Total { get; set; }

//±¾ÈÕ¸ÃÍæ¼Ò´ÓËùÓÐÏÂÏßÉíÉÏÄÜÌáÈ¡µÄ×ÜºèÀûÖµ
        [Order(4)] public int BonusAvailToday { get; set; }

        [Order(5)] public List<ReferralBrief> Referrals { get; set; }

        [Order(6)] public int LocalsId { get; set; }
    }
}
