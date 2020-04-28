using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4057)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GiftCodeRedeem_Re
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public byte[] Cardnumber { get; set; }

        [Order(2)] public int Codetype { get; set; }

        [Order(3)] public int Parenttype { get; set; }

        [Order(4)] public int RetCode { get; set; }
    }
}
