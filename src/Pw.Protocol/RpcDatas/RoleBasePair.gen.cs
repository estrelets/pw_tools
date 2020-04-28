﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleBasePair
    {
        [Order(0)] public RoleId Key { get; set; }

        [Order(1)] public GRoleBase Value { get; set; }
    }
}
