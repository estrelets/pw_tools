using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(152)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class QPAddCash
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int Cash { get; set; }

        [Order(2)] public int CashAfterDiscount { get; set; }

        [Order(3)] public int MerchantId { get; set; }
    }
}
