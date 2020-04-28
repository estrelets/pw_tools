using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4212)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerSendMail
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int Receiver { get; set; }

        [Order(3)] public byte[] Title { get; set; }

// max context length is 400 bytes
        [Order(4)] public byte[] Context { get; set; }

        [Order(5)] public int AttachObjId { get; set; }

        [Order(6)] public int AttachObjNum { get; set; }

        [Order(7)] public int AttachObjPos { get; set; }

        [Order(8)] public uint AttachMoney { get; set; }

// below parameter is provide by gameserver
        [Order(9)] public byte[] SenderName { get; set; }

        [Order(10)] public byte[] SyncData { get; set; }
    }
}
