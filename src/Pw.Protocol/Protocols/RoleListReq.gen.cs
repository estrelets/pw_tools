﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8121)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleListReq
    {
        [Order(0)] public long UserId { get; set; }
    }
}
