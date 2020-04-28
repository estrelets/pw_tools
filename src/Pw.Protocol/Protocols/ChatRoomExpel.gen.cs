using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(226)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ChatRoomExpel
    {
        [Order(0)] public ushort RoomId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int Owner { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
