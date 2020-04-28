using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4766)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleEnd
    {
        [Order(0)] public int BattleId { get; set; }

        [Order(1)] public int BattleResult { get; set; }

        [Order(2)] public int Attacker { get; set; }

        [Order(3)] public int Defender { get; set; }

        [Order(4)] public List<GCountryBattlePersonalScore> AttackerScore { get; set; }

        [Order(5)] public List<GCountryBattlePersonalScore> DefenderScore { get; set; }
    }
}
