using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GTerritory
    {
        [Order(0)] public char Id { get; set; }

        [Order(1)] public char Level { get; set; }

        [Order(2)] public char Color { get; set; }

        [Order(3)] public uint Owner { get; set; }

        [Order(4)] public uint Challenger { get; set; }

        [Order(5)] public uint BattleTime { get; set; }

        [Order(6)] public int Deposit { get; set; }

        [Order(7)] public int Maxbonus { get; set; }
    }
}
