﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(109)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerStatusAnnounce
    {
//status of the role, ongame, offline... 
        [Order(0)] public char Status { get; set; }

        [Order(1)] public OnlinePlayerStatus[] PlayerstatusList { get; set; }
    }
}
