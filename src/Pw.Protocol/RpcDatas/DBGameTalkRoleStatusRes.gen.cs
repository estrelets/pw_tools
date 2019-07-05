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
    public class DBGameTalkRoleStatusRes
    {
        [Order(0)]
        public int Status { get; set; }
        [Order(1)]
        public long ForbidTime { get; set; }
        [Order(2)]
        public uint UserId { get; set; }
    }
}
