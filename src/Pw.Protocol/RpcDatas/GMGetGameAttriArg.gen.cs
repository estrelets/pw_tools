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
    public class GMGetGameAttriArg
    {
        [Order(0)]
        public int GmRoleId { get; set; }
        [Order(1)]
        public uint LocalsId { get; set; }
        [Order(2)]
        public byte Attribute { get; set; }
    }
}
