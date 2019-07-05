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
    public class QPDiscountLevel
    {
        // ±¾¼¶³äÖµ¶î¶ÈÏÂÏÞ 
        [Order(0)]
        public int AmountBegin { get; set; }
        // ÕÛ¿Û 
        [Order(1)]
        public int Discount { get; set; }
    }
}
