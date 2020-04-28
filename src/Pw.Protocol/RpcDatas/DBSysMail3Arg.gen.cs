using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBSysMail3Arg
    {
        // ¶©µ¥ºÅ 
        [Order(0)] public long OrderId { get; set; }

        [Order(1)] public int UserId { get; set; }

        // ÊÕÓÊ¼þµÄ½ÇÉ«id 
        [Order(2)] public long RoleId { get; set; }

        // ÊÕÓÊ¼þµÄ½ÇÉ«Ãû 
        [Order(3)] public byte[] RoleName { get; set; }

        // ÉÌ³ÇÊôÐÔ 
        [Order(4)] public int GoodsFlag { get; set; }

        // ÉÌ³ÇÕæÊµ³É½»¼Û 
        [Order(5)] public int GoodsPrice { get; set; }

        // ÎïÆ·ÕÛÇ°±ê¼Û 
        [Order(6)] public int GoodsPriceBeforeDiscount { get; set; }

        [Order(7)] public int GoodsPaytype { get; set; }

        [Order(8)] public GMail Mail { get; set; }
    }
}
