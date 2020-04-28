using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CouponExchangeArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int CouponNumber { get; set; }

        [Order(2)] public int CashNumber { get; set; }

        [Order(3)] public long Timestamp { get; set; }

        [Order(4)] public int Reserved1 { get; set; }

        [Order(5)] public int Reserved2 { get; set; }
    }
}
