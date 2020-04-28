using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GGroupInfo
    {
        [Order(0)] public char GId { get; set; }

        [Order(1)] public byte[] Name { get; set; }
    }
}
