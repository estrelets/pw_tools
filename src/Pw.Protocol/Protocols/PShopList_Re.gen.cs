﻿using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(927)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopList_Re
    {
        [Order(0)] public int LocalsId { get; set; }

        [Order(1)] public PShopEntry[] Shoplist { get; set; }
    }
}
