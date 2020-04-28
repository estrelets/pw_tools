using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(228)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ChatRoomList
    {
        [Order(0)] public ushort Begin { get; set; }

        [Order(1)] public char Reverse { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
