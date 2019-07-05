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
    public class DBFactionPromoteRes
    {
        [Order(0)]
        public int RetCode { get; set; }
        [Order(1)]
        public char SupRole { get; set; }
        [Order(2)]
        public char NewRole { get; set; }
    }
}
