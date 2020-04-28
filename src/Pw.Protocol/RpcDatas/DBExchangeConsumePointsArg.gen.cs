using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBExchangeConsumePointsArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int UserId { get; set; }

        [Order(2)] public int ConsumePoints { get; set; }

        //¿ªÊ¼·µ»¹µÄÊ±¼ä
        [Order(3)] public GRewardItem[] Rewardlist { get; set; }
    }
}
