using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACThreadTime
    {
        [Order(0)] public int ThreadId { get; set; }

        [Order(1)] public int AllSecs { get; set; }

        [Order(2)] public int KernelSecs { get; set; }

        [Order(3)] public int UserSecs { get; set; }
    }
}
