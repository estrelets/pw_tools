using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBBattleChallengeRes
    {
        [Order(0)] public short RetCode { get; set; }

        [Order(1)] public int ChallengeRes { get; set; }

        [Order(2)] public uint Deposit { get; set; }

        [Order(3)] public GMailHeader InformLoser { get; set; }

        [Order(4)] public GMailSyncData SyncData { get; set; }
    }
}
