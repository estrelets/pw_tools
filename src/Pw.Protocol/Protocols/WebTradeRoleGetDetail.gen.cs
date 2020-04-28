﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4329)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class WebTradeRoleGetDetail
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
