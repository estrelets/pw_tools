using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBWebTradeSoldRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public GMailHeader InformSeller { get; set; }

        [Order(2)] public GMailHeader InformBuyer { get; set; }

        //´ËÖµ±íÊ¾Êµ¼ÊÊÕµ½ÎïÆ·µÄ½ÇÉ«roleid
        [Order(3)] public int BuyerRoleId { get; set; }
    }
}
