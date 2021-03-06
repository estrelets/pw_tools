﻿using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GFriendList
    {
        [Order(0)] public GGroupInfo[] Groups { get; set; }

        [Order(1)] public GFriendInfo[] Friends { get; set; }
    }
}
