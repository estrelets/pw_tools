using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8049)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class BillingBalanceSA_Re
    {
//0³É¹¦£¬·Ç0Ê§°Ü
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int UserId { get; set; }

//Óà¶î
        [Order(2)] public int Cashremain { get; set; }
    }
}
