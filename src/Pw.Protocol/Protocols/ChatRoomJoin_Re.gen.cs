using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(224)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ChatRoomJoin_Re
    {
        [Order(0)] public short RetCode { get; set; }

        [Order(1)] public ushort RoomId { get; set; }

        [Order(2)] public int RoleId { get; set; }

        [Order(3)] public byte[] Name { get; set; }

        [Order(4)] public GRoomDetail Detail { get; set; }

        [Order(5)] public uint LocalsId { get; set; }
    }
}
