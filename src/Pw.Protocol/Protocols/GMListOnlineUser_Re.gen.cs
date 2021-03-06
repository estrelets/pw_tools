﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(353)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMListOnlineUser_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int GmRoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public int Handler { get; set; }

        [Order(4)] public GMPlayerInfo[] Userlist { get; set; }
    }
}
