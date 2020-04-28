using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class QPDiscountInfo
    {
        // ÉÌ¼Òid 
        [Order(0)] public int Id { get; set; }

        // ÉÌ¼ÒÃû£¬UTF-16LE±àÂë 
        [Order(1)] public byte[] Name { get; set; }

        // ·Ö×éµÄÕÛ¿Û 
        [Order(2)] public QPDiscountLevel[] Discount { get; set; }
    }
}
