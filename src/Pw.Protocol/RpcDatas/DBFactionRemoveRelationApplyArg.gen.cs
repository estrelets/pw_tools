using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBFactionRemoveRelationApplyArg
    {
        [Order(0)] public int FId { get; set; }

        [Order(1)] public int DstFId { get; set; }

        [Order(2)] public char Force { get; set; }

        [Order(3)] public int EndTime { get; set; }

        [Order(4)] public int OpTime { get; set; }
    }
}
