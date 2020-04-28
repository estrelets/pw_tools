using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4752)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleApply_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int CountryId { get; set; }

        [Order(2)] public int CountryInvalidTimestamp { get; set; }

        [Order(3)] public int CapitalWorldtag { get; set; }

        [Order(4)] public float CapitalPosx { get; set; }

        [Order(5)] public float CapitalPosy { get; set; }

        [Order(6)] public float CapitalPosz { get; set; }

        [Order(7)] public List<CountryBattleApplyEntry> List { get; set; }
    }
}
