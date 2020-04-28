using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(96)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PrivateChat
    {
        [Order(0)] public byte Channel { get; set; }

        [Order(1)] public byte Emotion { get; set; }

        [Order(2)] public byte[] SrcName { get; set; }

        [Order(3)] public int SrcRoleId { get; set; }

        [Order(4)] public byte[] DstName { get; set; }

        [Order(5)] public int DstRoleId { get; set; }

        [Order(6)] public byte[] Msg { get; set; }

        [Order(7)] public byte[] Data { get; set; }

        [Order(8)] public int SrcLevel { get; set; }
    }
}
