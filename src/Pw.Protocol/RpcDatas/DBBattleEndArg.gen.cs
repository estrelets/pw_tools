using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBBattleEndArg
    {
        [Order(0)] public int BattleId { get; set; }

        [Order(1)] public int Result { get; set; }

        [Order(2)] public int Color { get; set; }

        [Order(3)] public uint Defender { get; set; }

        [Order(4)] public uint Attacker { get; set; }
    }
}
