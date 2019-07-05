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
    public class AnnounceFactionRoleDelArg
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public char ZoneId { get; set; }
        [Order(2)]
        public uint Faction { get; set; }
    }
}
