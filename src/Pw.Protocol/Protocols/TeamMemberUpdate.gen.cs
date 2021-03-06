﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8154)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TeamMemberUpdate
    {
        [Order(0)] public long TeamId { get; set; }

        [Order(1)] public List<long> Members { get; set; }

        [Order(2)] public char Operation { get; set; }
    }
}
