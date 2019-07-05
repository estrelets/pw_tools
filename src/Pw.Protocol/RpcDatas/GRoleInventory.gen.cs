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
    public class GRoleInventory
    {
        [Order(0)]
        public uint Id { get; set; }
        [Order(1)]
        public int Pos { get; set; }
        [Order(2)]
        public int Count { get; set; }
        [Order(3)]
        public int MaxCount { get; set; }
        [Order(4)]
        public byte[] Data { get; set; }
        [Order(5)]
        public int Proctype { get; set; }
        [Order(6)]
        public int ExpireDate { get; set; }
        [Order(7)]
        public int Guid1 { get; set; }
        [Order(8)]
        public int Guid2 { get; set; }
        [Order(9)]
        public int Mask { get; set; }
    }
}
