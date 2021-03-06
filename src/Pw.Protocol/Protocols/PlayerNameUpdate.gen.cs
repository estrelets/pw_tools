﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(158)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerNameUpdate
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public byte[] NewName { get; set; }

        [Order(2)] public List<int> LinkLocalsidList { get; set; }
    }
}
