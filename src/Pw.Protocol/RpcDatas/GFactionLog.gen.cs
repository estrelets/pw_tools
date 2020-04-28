using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GFactionLog
    {
        [Order(0)] public uint RId { get; set; }

        [Order(1)] public byte[] Name { get; set; }

        [Order(2)] public char Action { get; set; }

        [Order(3)] public GItem[] Items { get; set; }
    }
}
