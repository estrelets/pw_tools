﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4802)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerFactionInfo_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public PFactionInfo[] FactionInfo { get; set; }
    }
}
