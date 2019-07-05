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
    public class ACPlatformInfo
    {
        [Order(0)]
        public int Id { get; set; }
        [Order(1)]
        public int MajorVersion { get; set; }
        [Order(2)]
        public int MinorVersion { get; set; }
        [Order(3)]
        public int BuildNumber { get; set; }
        [Order(4)]
        public int Count { get; set; }
    }
}
