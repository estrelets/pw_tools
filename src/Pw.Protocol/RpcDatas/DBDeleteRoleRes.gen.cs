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
    public class DBDeleteRoleRes
    {
        [Order(0)]
        public int RetCode { get; set; }
        [Order(1)]
        public int UserId { get; set; }
        [Order(2)]
        public uint Rolelist { get; set; }
        [Order(3)]
        public uint Faction { get; set; }
        [Order(4)]
        public byte[] RoleName { get; set; }
    }
}
