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
    public class RoleRes
    {
        [Order(0)]
        public int RetCode { get; set; }
        [Order(1)]
        public int DataMask { get; set; }
        [Order(2)]
        public char GameserverId { get; set; }
        [Order(3)]
        public GRoleDetail Value { get; set; }
    }
}
