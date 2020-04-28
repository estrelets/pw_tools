using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(855)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class BattleChallengeMap_Re
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public ushort RetCode { get; set; }

        [Order(2)] public int Status { get; set; }

        [Order(3)] public uint Maxbonus { get; set; }

        [Order(4)] public List<GBattleChallenge> Cities { get; set; }

        [Order(5)] public int RandNum { get; set; }

        [Order(6)] public uint LocalsId { get; set; }
    }
}
