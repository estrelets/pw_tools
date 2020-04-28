using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GFactionBaseInfo
    {
        [Order(0)] public uint FId { get; set; }

        [Order(1)] public byte[] Name { get; set; }

        [Order(2)] public char Level { get; set; }

        [Order(3)] public short MemNum { get; set; }
    }
}
