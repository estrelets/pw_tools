﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8132)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleOfflineMessages
    {
        [Order(0)] public long Receiver { get; set; }

        [Order(1)] public RoleMsgBean[] Messages { get; set; }
    }
}
