using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBConfig
    {
        [Order(0)] public uint InitTime { get; set; }

        [Order(1)] public uint OpenTime { get; set; }
    }
}
