using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(851)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class BattleGetMap_Re
    {
        [Order(0)] public ushort RetCode { get; set; }

        [Order(1)] public ushort MaxbId { get; set; }

        [Order(2)] public int Status { get; set; }

        [Order(3)] public List<GTerritory> Cities { get; set; }

        [Order(4)] public int BonusId { get; set; }

        [Order(5)] public int BonusCount1 { get; set; }

        [Order(6)] public int BonusCount2 { get; set; }

        [Order(7)] public int BonusCount3 { get; set; }

        [Order(8)] public uint LocalsId { get; set; }
    }
}
