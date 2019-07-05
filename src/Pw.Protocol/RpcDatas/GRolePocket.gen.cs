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
    public class GRolePocket
    {
        [Order(0)]
        public uint Capacity { get; set; }
        [Order(1)]
        public uint Timestamp { get; set; }
        [Order(2)]
        public uint Money { get; set; }
        [Order(3)]
        public GRoleInventory[] Items { get; set; }
        [Order(4)]
        public int Reserved1 { get; set; }
        [Order(5)]
        public int Reserved2 { get; set; }
    }
}
