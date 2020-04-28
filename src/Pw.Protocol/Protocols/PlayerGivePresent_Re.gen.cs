using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(3066)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerGivePresent_Re
    {
        [Order(0)] public int LocalsId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public uint CashCost { get; set; }

        [Order(3)] public int RetCode { get; set; }
    }
}
