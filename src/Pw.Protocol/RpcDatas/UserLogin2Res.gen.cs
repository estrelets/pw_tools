using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class UserLogin2Res
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RemainPlaytime { get; set; }

        [Order(2)] public int Func { get; set; }

        [Order(3)] public int Funcparm { get; set; }

        [Order(4)] public char Blisgm { get; set; }

        [Order(5)] public int FreeTimeLeft { get; set; }

        [Order(6)] public int FreeTimeEnd { get; set; }

        [Order(7)] public int Creatime { get; set; }

        [Order(8)] public int Adduppoint { get; set; }

        [Order(9)] public int Soldpoint { get; set; }

        [Order(10)] public byte[] Auth { get; set; }

        [Order(11)] public byte Gender { get; set; }

        [Order(12)] public int RemainCoupon { get; set; }

        [Order(13)] public int TodayExchangeCoupon { get; set; }

        [Order(14)] public int TodayRemainCoupon { get; set; }

        [Order(15)] public byte[] NickName { get; set; }
    }
}
