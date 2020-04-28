using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBAuctionOpenArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint AuctionId { get; set; }

        [Order(2)] public ushort Category { get; set; }

        [Order(3)] public int ItemId { get; set; }

        [Order(4)] public int ItemPos { get; set; }

        [Order(5)] public int ItemNum { get; set; }

        [Order(6)] public uint Baseprice { get; set; }

        [Order(7)] public uint Binprice { get; set; }

        [Order(8)] public int ElapseTime { get; set; }

        [Order(9)] public int EndTime { get; set; }

        [Order(10)] public uint Deposit { get; set; }

        [Order(11)] public GMailSyncData SyncData { get; set; }
    }
}
