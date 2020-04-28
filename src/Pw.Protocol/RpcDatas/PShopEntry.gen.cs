using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopEntry
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Shoptype { get; set; }

        [Order(2)] public int Createtime { get; set; }

        //À¸Î»×´Ì¬:0x01:³öÊÛÀ¸·Ç¿Õ;0x02:ÊÕ¹ºÀ¸·Ç¿Õ;0x03:¶þÕß¾ù·Ç¿Õ
        [Order(3)] public int Invstate { get; set; }
    }
}
