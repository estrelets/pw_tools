using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4956)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RewardMatureNotice
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int BonusReward { get; set; }

        [Order(2)] public int LocalsId { get; set; }
    }
}
