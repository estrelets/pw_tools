using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBWebTradePostArg
    {
        [Order(0)] public long Sn { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int State { get; set; }

        [Order(3)] public int PostEndtime { get; set; }

        [Order(4)] public int ShowEndtime { get; set; }

        [Order(5)] public int SellEndtime { get; set; }

        [Order(6)] public int CommodityId { get; set; }
    }
}
