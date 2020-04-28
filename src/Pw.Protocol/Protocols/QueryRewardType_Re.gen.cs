using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(511)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class QueryRewardType_Re
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Reward { get; set; }

        [Order(2)] public int Reward2 { get; set; }

        [Order(3)] public int Param { get; set; }

        [Order(4)] public int Rewardmask { get; set; }
    }
}
