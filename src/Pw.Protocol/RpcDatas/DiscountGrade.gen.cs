using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DiscountGrade
    {
        // ±¾¼¶³äÖµ¶î¶ÈÏÂÏÞ 
        [Order(0)] public int AmountBegin { get; set; }

        // ÕÛ¿Û 
        [Order(1)] public int Discount { get; set; }

        [Order(2)] public int Reserved1 { get; set; }

        [Order(3)] public byte[] Reserved2 { get; set; }
    }
}
