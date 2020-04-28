using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FMemberInfo
    {
        [Order(0)] public uint RoleId { get; set; }

        [Order(1)] public byte Level { get; set; }

        [Order(2)] public byte Occupation { get; set; }

        [Order(3)] public byte FRoleId { get; set; }

        [Order(4)] public ushort Loginday { get; set; }

        [Order(5)] public byte OnlineStatus { get; set; }

        [Order(6)] public byte[] Name { get; set; }

        [Order(7)] public byte[] NickName { get; set; }

        [Order(8)] public int Contrib { get; set; }

        [Order(9)] public byte Delayexpel { get; set; }

        [Order(10)] public int Expeltime { get; set; }

        [Order(11)] public int Reputation { get; set; }

        [Order(12)] public byte ReincarnTimes { get; set; }

        [Order(13)] public byte Gender { get; set; }
    }
}
