using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBBuyPointArg
    {
        [Order(0)] public int Buyer { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int SellId { get; set; }

        [Order(3)] public int Seller { get; set; }

        [Order(4)] public int Timestamp { get; set; }

        [Order(5)] public int Money { get; set; }
    }
}
