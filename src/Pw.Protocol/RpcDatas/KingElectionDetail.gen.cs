﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class KingElectionDetail
    {
        [Order(0)] public KEKing King { get; set; }

        [Order(1)] public KECandidate[] CandidateList { get; set; }

        [Order(2)] public int Reserved1 { get; set; }

        [Order(3)] public int Reserved2 { get; set; }

        [Order(4)] public int Reserved3 { get; set; }

        [Order(5)] public int Reserved4 { get; set; }

        [Order(6)] public int Reserved5 { get; set; }
    }
}
