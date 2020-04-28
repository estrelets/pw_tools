using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4214)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SysSendMail
    {
        [Order(0)] public uint TId { get; set; }

        [Order(1)] public int SysId { get; set; }

// NPC or Bidding-system
        [Order(2)] public byte SysType { get; set; }

        [Order(3)] public int Receiver { get; set; }

        [Order(4)] public byte[] Title { get; set; }

// max context length is 400 bytes
        [Order(5)] public byte[] Context { get; set; }

        [Order(6)] public GRoleInventory AttachObj { get; set; }

        [Order(7)] public uint AttachMoney { get; set; }
    }
}
