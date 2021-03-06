﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(218)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetSavedMsg_Re
    {
        [Order(0)] public char RetCode { get; set; }

        [Order(1)] public Message[] Messages { get; set; }

        [Order(2)] public int RoleId { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
