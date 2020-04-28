using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8152)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TeamCreate
    {
        [Order(0)] public TeamBean Team { get; set; }
    }
}
