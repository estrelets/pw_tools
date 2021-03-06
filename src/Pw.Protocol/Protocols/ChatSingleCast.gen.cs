﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(94)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ChatSingleCast
    {
        [Order(0)] public byte Channel { get; set; }

        [Order(1)] public byte Emotion { get; set; }

        [Order(2)] public int SrcRoleId { get; set; }

        [Order(3)] public int DstRoleId { get; set; }

        [Order(4)] public uint DstlocalsId { get; set; }

        [Order(5)] public byte[] Msg { get; set; }

        [Order(6)] public byte[] Data { get; set; }
    }
}
