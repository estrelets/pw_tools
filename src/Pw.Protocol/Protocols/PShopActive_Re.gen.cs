﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(915)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopActive_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int LocalsId { get; set; }

        [Order(2)] public int Status { get; set; }

        [Order(3)] public int Expiretime { get; set; }
    }
}
