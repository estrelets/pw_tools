using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopBase
    {
        [Order(0)] public int RoleId { get; set; }

        // ¹²8ÖÖ:0-7
        [Order(1)] public int Shoptype { get; set; }

        [Order(2)] public PShopItem[] Blist { get; set; }

        [Order(3)] public PShopItem[] Slist { get; set; }
    }
}
