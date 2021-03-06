﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GSysLog
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Time { get; set; }

        [Order(2)] public int Ip { get; set; }

        [Order(3)] public short Source { get; set; }

        [Order(4)] public int Money { get; set; }

        [Order(5)] public GRoleInventory[] Items { get; set; }

        [Order(6)] public int Reserved1 { get; set; }

        [Order(7)] public int Reserved2 { get; set; }

        [Order(8)] public int Reserved3 { get; set; }

        [Order(9)] public int Reserved4 { get; set; }
    }
}
