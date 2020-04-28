using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4782)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleKingAssignAssault_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int DomainId { get; set; }

        [Order(2)] public char AssaultType { get; set; }

        [Order(3)] public int CommandPoint { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
