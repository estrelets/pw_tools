using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(869)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SendBattleChallenge
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public short Id { get; set; }

        [Order(2)] public uint FactionId { get; set; }

        [Order(3)] public uint Deposit { get; set; }

        [Order(4)] public int Authentication { get; set; }

        [Order(5)] public uint LocalsId { get; set; }

        [Order(6)] public uint Maxbonus { get; set; }

        [Order(7)] public GMailSyncData SyncData { get; set; }
    }
}
