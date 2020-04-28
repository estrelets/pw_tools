using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class MailGoodsInventory
    {
        // ÎïÆ·id 
        [Order(0)] public int GoodsId { get; set; }

        // ÎïÆ·ÊýÁ¿ 
        [Order(1)] public int Count { get; set; }

        [Order(2)] public int Proctype { get; set; }

        // ÉÌ³ÇÊôÐÔ 
        [Order(3)] public int GoodsFlag { get; set; }

        // ÉÌ³ÇÕæÊµ³É½»¼Û 
        [Order(4)] public int GoodsPrice { get; set; }

        // ÎïÆ·ÕÛÇ°±ê¼Û 
        [Order(5)] public int GoodsPriceBeforeDiscount { get; set; }

        [Order(6)] public int Paytype { get; set; }

        [Order(7)] public byte[] Reserved2 { get; set; }
    }
}
