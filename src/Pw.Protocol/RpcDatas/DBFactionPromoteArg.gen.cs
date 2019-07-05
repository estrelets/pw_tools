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
    public class DBFactionPromoteArg
    {
        [Order(0)]
        public uint FId { get; set; }
        [Order(1)]
        public uint Superior { get; set; }
        [Order(2)]
        public uint RoleId { get; set; }
        [Order(3)]
        public char SupRole { get; set; }
        [Order(4)]
        public char NewRole { get; set; }
        [Order(5)]
        public int Max { get; set; }
    }
}
