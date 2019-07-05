using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.Protocols;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TradeInventoryArg
    {
        [Order(0)]
        public uint Roleid1 { get; set; }
        [Order(1)]
        public uint Roleid2 { get; set; }
    }
}
