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
    public class GCity
    {
        [Order(0)]
        public char Id { get; set; }
        [Order(1)]
        public char Level { get; set; }
        [Order(2)]
        public uint Owner { get; set; }
    }
}
