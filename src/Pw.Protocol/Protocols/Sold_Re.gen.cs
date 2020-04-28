using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8031)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class Sold_Re
    {
        [Order(0)] public int ZoneId { get; set; }

        [Order(1)] public int SelleruserId { get; set; }

        [Order(2)] public long SellerRoleId { get; set; }

        [Order(3)] public int BuyeruserId { get; set; }

        [Order(4)] public long BuyerRoleId { get; set; }

        [Order(5)] public long Sn { get; set; }

        [Order(6)] public int RetCode { get; set; }

        [Order(7)] public long OrderId { get; set; }

        [Order(8)] public int Reserved1 { get; set; }

        [Order(9)] public int Reserved2 { get; set; }
    }
}
