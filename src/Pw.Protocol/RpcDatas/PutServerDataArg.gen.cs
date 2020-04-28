using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PutServerDataArg
    {
        [Order(0)] public int WorldTag { get; set; }

        [Order(1)] public int DataMask { get; set; }

        [Order(2)] public int Priority { get; set; }

        [Order(3)] public GServerData Data { get; set; }
    }
}
