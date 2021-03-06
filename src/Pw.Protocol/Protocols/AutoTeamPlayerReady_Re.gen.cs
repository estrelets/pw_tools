﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(965)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AutoTeamPlayerReady_Re
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int LeaderId { get; set; }

        [Order(2)] public char RetCode { get; set; }
    }
}
