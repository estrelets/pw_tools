using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8021)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class Post_Re
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public long RoleId { get; set; }

        [Order(2)] public long Sn { get; set; }

// Ö»¹Ø×¢showperiodºÍpostperiod¼´¿É
        [Order(3)] public TimeInfo Time { get; set; }

        [Order(4)] public int RetCode { get; set; }

        [Order(5)] public long Timestamp { get; set; }

        [Order(6)] public int Buylevel { get; set; }

        [Order(7)] public int CommodityId { get; set; }

        [Order(8)] public int Reserved2 { get; set; }
    }
}
