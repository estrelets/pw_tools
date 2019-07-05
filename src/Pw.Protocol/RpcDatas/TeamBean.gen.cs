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
    public class TeamBean
    {
        [Order(0)]
        public long TeamId { get; set; }
        [Order(1)]
        public long Captain { get; set; }
        [Order(2)]
        public List<long> Members { get; set; }
    }
}
