﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(119)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetPlayerIDByName_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public byte[] RoleName { get; set; }

        [Order(3)] public int RoleId { get; set; }

        [Order(4)] public byte Reason { get; set; }
    }
}
