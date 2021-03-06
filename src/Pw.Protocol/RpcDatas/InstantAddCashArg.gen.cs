﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class InstantAddCashArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int Loginip { get; set; }

        [Order(2)] public byte[] Cardnum { get; set; }

        [Order(3)] public byte[] Cardpasswd { get; set; }

        [Order(4)] public int Reserved { get; set; }
    }
}
