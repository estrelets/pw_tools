﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4524)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionRelationRecvApply
    {
        [Order(0)] public int ApplyType { get; set; }

        [Order(1)] public int SrcFId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
