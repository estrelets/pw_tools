using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBAuctionBidArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint AuctionId { get; set; }

        [Order(2)] public uint Bidprice { get; set; }

        [Order(3)] public char Bin { get; set; }

        [Order(4)] public GMailSyncData SyncData { get; set; }
    }
}
