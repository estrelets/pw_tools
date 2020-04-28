using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DelMemberArg
    {
        [Order(0)] public uint FId { get; set; }

        [Order(1)] public uint RId { get; set; }
    }
}
