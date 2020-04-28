using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBAuctionBidRes
    {
        [Order(0)] public byte RetCode { get; set; }

        [Order(1)] public uint Bidprice { get; set; }

        [Order(2)] public GMailHeader InformSeller { get; set; }

        [Order(3)] public GMailHeader InformLoser { get; set; }

        [Order(4)] public GMailHeader InformWinner { get; set; }

        [Order(5)] public int ExtendTime { get; set; }

        [Order(6)] public GMailSyncData SyncData { get; set; }
    }
}
