﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBGameTalkRoleRelationRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public RoleBean Info { get; set; }

        [Order(2)] public FactionIDBean[] Factions { get; set; }

        [Order(3)] public DBRoleGroup[] Groups { get; set; }
    }
}
