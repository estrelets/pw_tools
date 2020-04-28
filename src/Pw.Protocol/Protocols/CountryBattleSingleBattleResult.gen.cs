using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4780)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleSingleBattleResult
    {
        [Order(0)] public int DomainId { get; set; }

        [Order(1)] public int SingleBattleTotalScore { get; set; }

        [Order(2)] public int PlayerSingleBattleScore { get; set; }

        [Order(3)] public int PlayerRank { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
