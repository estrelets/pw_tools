﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(126)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FaceModifyCancel
    {
        [Order(0)] public int RoleId { get; set; }
    }
}
