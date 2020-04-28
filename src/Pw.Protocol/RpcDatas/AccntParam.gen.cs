using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AccntParam
    {
        [Order(0)] public uint Type { get; set; }

        [Order(1)] public uint Value { get; set; }
    }
}
