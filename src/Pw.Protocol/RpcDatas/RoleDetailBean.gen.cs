﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleDetailBean
    {
        [Order(0)] public RoleInfoBean Info { get; set; }

        [Order(1)] public RoleStatusBean Status { get; set; }

        [Order(2)] public RoleForbidBean ForbId { get; set; }
    }
}
