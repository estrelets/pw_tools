using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ServerForbidControlArg
    {
        // 0 ²éÑ¯ 1 ÉèÖÃ
        [Order(0)] public char Oper { get; set; }

        [Order(1)] public byte[] Param { get; set; }
    }
}
