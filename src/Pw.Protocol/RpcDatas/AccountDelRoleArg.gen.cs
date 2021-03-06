﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AccountDelRoleArg
    {
        [Order(0)] public char ZoneId { get; set; }

        [Order(1)] public int RoleId { get; set; }
    }
}
