﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RolenameExistsRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int ZoneId { get; set; }

        [Order(2)] public int RoleId { get; set; }

        [Order(3)] public int Status { get; set; }

        [Order(4)] public int Time { get; set; }
    }
}
