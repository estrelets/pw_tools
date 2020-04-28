using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(222)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ChatRoomInvite_Re
    {
        [Order(0)] public ushort RoomId { get; set; }

        [Order(1)] public int Invitee { get; set; }

        [Order(2)] public int Inviter { get; set; }

        [Order(3)] public short RetCode { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
