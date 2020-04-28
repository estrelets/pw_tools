using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(220)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ChatRoomCreate_Re
    {
        [Order(0)] public short RetCode { get; set; }

        [Order(1)] public ushort RoomId { get; set; }

        [Order(2)] public byte[] Subject { get; set; }

        [Order(3)] public ushort Capacity { get; set; }

        [Order(4)] public byte Status { get; set; }

        [Order(5)] public uint LocalsId { get; set; }
    }
}
