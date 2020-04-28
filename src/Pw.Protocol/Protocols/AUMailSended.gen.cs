﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(235)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AUMailSended
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Level { get; set; }

        [Order(2)] public char ExtReward { get; set; }
    }
}
