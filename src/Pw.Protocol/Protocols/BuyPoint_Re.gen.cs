﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(608)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class BuyPoint_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int SellId { get; set; }

        [Order(3)] public int Seller { get; set; }
    }
}
