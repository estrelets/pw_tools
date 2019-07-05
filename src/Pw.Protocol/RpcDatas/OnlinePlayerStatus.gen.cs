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
    public class OnlinePlayerStatus
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public int GId { get; set; }
        [Order(2)]
        public int LinkId { get; set; }
        [Order(3)]
        public uint LinkSId { get; set; }
    }
}
