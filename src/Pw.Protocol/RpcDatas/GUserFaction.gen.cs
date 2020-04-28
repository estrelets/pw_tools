using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GUserFaction
    {
        [Order(0)] public uint RId { get; set; }

        [Order(1)] public byte[] Name { get; set; }

        [Order(2)] public uint FId { get; set; }

        [Order(3)] public char Cls { get; set; }

        [Order(4)] public char Role { get; set; }

        [Order(5)] public byte[] Delayexpel { get; set; }

        [Order(6)] public byte[] Extend { get; set; }

        [Order(7)] public byte[] NickName { get; set; }
    }
}
