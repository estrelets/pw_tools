﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CanChangeRolenameArg
    {
        [Order(0)] public byte[] RoleName { get; set; }

        [Order(1)] public int Setcanchange { get; set; }
    }
}
