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
    public class RoleInfoBean
    {
        [Order(0)]
        public long RoleId { get; set; }
        [Order(1)]
        public byte[] RoleName { get; set; }
        [Order(2)]
        public byte Gender { get; set; }
        [Order(3)]
        public int Race { get; set; }
        [Order(4)]
        public int Occupation { get; set; }
        [Order(5)]
        public int Level { get; set; }
        [Order(6)]
        public byte[] Extinfo { get; set; }
    }
}
