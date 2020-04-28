using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GTerritoryDetail
    {
        [Order(0)] public short Id { get; set; }

        [Order(1)] public short Level { get; set; }

        [Order(2)] public uint Owner { get; set; }

        [Order(3)] public int OccupyTime { get; set; }

        [Order(4)] public uint Challenger { get; set; }

        [Order(5)] public uint Deposit { get; set; }

        [Order(6)] public int CutoffTime { get; set; }

        [Order(7)] public int BattleTime { get; set; }

        [Order(8)] public int BonusTime { get; set; }

        [Order(9)] public int Color { get; set; }

        [Order(10)] public int Status { get; set; }

        [Order(11)] public int Timeout { get; set; }

        [Order(12)] public int Maxbonus { get; set; }

        [Order(13)] public int ChallengeTime { get; set; }

        [Order(14)] public byte[] Challengerdetails { get; set; }

        [Order(15)] public char Reserved1 { get; set; }

        [Order(16)] public char Reserved2 { get; set; }

        [Order(17)] public char Reserved3 { get; set; }
    }
}
