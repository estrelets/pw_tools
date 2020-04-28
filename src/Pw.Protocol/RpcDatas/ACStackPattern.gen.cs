using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACStackPattern
    {
        [Order(0)] public int Caller { get; set; }

        [Order(1)] public int Size { get; set; }

        [Order(2)] public int Pattern { get; set; }

        [Order(3)] public int Count { get; set; }

        [Order(4)] public int CountHd { get; set; }
    }
}
