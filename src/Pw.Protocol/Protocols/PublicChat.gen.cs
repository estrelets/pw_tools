using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(79)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PublicChat
    {
        [Order(0)] public byte Channel { get; set; }

        [Order(1)] public byte Emotion { get; set; }

        [Order(2)] public int RoleId { get; set; }

        [Order(3)] public uint LocalsId { get; set; }

        [Order(4)] public byte[] Msg { get; set; }

        [Order(5)] public byte[] Data { get; set; }
    }
}
