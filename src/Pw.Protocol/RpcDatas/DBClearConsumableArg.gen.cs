﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBClearConsumableArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int Logintime { get; set; }

        [Order(2)] public char Dryrun { get; set; }
    }
}
