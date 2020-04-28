﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(867)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class BattleStatus_Re
    {
        [Order(0)] public ushort RetCode { get; set; }

        [Order(1)] public List<char> Cities { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
