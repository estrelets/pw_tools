using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GRoleTask
    {
        [Order(0)] public byte[] TaskData { get; set; }

        [Order(1)] public byte[] TaskComplete { get; set; }

        [Order(2)] public byte[] TaskFinishtime { get; set; }

        [Order(3)] public GRoleInventory[] TaskInventory { get; set; }
    }
}
