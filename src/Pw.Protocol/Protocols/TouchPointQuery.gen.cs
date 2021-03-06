﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4050)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TouchPointQuery
    {
        [Order(0)] public int RoleId { get; set; }
    }
}
