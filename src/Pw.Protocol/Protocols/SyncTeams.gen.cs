using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8151)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SyncTeams
    {
        [Order(0)] public TeamBean[] Teams { get; set; }
    }
}
