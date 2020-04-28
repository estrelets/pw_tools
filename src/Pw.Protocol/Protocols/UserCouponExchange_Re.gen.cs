using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(141)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class UserCouponExchange_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RemainCoupon { get; set; }

        [Order(2)] public int TodayExchangeCoupon { get; set; }

        [Order(3)] public int TodayRemainCoupon { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
