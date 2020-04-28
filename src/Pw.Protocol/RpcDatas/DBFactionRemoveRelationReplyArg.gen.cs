using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBFactionRemoveRelationReplyArg
    {
        [Order(0)] public int FId { get; set; }

        [Order(1)] public int DstFId { get; set; }

        [Order(2)] public char Agree { get; set; }
    }
}
