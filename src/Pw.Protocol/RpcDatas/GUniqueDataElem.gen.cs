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
    public class GUniqueDataElem
    {
        [Order(0)]
        public char Vtype { get; set; }
        [Order(1)]
        public byte[] Value { get; set; }
        [Order(2)]
        public int Version { get; set; }
        [Order(3)]
        public short Reserved { get; set; }
    }
}
