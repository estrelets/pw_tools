using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4781)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleKingAssignAssault
    {
        [Order(0)] public int KingRoleId { get; set; }

        [Order(1)] public int DomainId { get; set; }

        [Order(2)] public char AssaultType { get; set; }
    }
}
