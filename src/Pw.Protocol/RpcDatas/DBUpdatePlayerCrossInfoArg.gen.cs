﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBUpdatePlayerCrossInfoArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int RemoteRoleId { get; set; }

        [Order(2)] public int UserId { get; set; }

        [Order(3)] public int RemoteZoneId { get; set; }
    }
}
