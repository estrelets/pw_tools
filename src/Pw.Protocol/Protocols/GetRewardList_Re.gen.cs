using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4953)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetRewardList_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int ConsumePoints { get; set; }

        [Order(3)] public int StartIndex { get; set; }

        [Order(4)] public int Total { get; set; }

        [Order(5)] public RewardItem[] Rewardlist { get; set; }

        [Order(6)] public int LocalsId { get; set; }
    }
}
