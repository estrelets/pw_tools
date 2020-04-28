using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GRoomDetail
    {
        [Order(0)] public ushort RoomId { get; set; }

        [Order(1)] public byte[] Subject { get; set; }

        [Order(2)] public byte[] Owner { get; set; }

        [Order(3)] public ushort Capacity { get; set; }

        [Order(4)] public byte Status { get; set; }

        [Order(5)] public GChatMember[] Members { get; set; }
    }
}
