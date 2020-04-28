using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class WebOrderItemDetail
    {
        [Order(0)] public int UserId { get; set; }

        // ÊÕÓÊ¼þµÄ½ÇÉ«id 
        [Order(1)] public int RoleId { get; set; }

        // ÎïÆ·id 
        [Order(2)] public int GoodsId { get; set; }

        // ÎïÆ·ÊýÁ¿ 
        [Order(3)] public int Count { get; set; }

        [Order(4)] public int Proctype { get; set; }

        // ÉÌ³ÇÊôÐÔ 
        [Order(5)] public int GoodsFlag { get; set; }

        // ÉÌ³ÇÕæÊµ³É½»¼Û 
        [Order(6)] public int GoodsPrice { get; set; }

        // ÎïÆ·ÕÛÇ°±ê¼Û 
        [Order(7)] public int GoodsPriceBeforeDiscount { get; set; }

        [Order(8)] public int GoodsPaytype { get; set; }

        // ÓÊ¼þ¸½´øµÄ½ð±Ò 
        [Order(9)] public uint AttachMoney { get; set; }

        [Order(10)] public int TimeStamp { get; set; }

        [Order(11)] public int Reserved1 { get; set; }

        [Order(12)] public int Reserved2 { get; set; }

        [Order(13)] public int Reserved3 { get; set; }
    }
}
