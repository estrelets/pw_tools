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
    public class RoleStorehousePair
    {
        [Order(0)]
        public RoleId Key { get; set; }
        [Order(1)]
        public GRoleStorehouse Value { get; set; }
    }
}
