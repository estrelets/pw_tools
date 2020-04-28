using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMeridianData
    {
        [Order(0)] public int MeridianLevel { get; set; }

        [Order(1)] public int LifegateTimes { get; set; }

        [Order(2)] public int DeathgateTimes { get; set; }

        [Order(3)] public int FreeRefineTimes { get; set; }

        [Order(4)] public int PaidRefineTimes { get; set; }

        [Order(5)] public int PlayerLoginTime { get; set; }

        [Order(6)] public int ContinuLoginDays { get; set; }

        [Order(7)] public int TrigramsMap1 { get; set; }

        [Order(8)] public int TrigramsMap2 { get; set; }

        [Order(9)] public int TrigramsMap3 { get; set; }

        [Order(10)] public int Reserved1 { get; set; }

        [Order(11)] public int Reserved2 { get; set; }

        [Order(12)] public int Reserved3 { get; set; }

        [Order(13)] public int Reserved4 { get; set; }
    }
}
