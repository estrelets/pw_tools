﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4908)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RefGetReferenceCode
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int LocalsId { get; set; }
    }
}
