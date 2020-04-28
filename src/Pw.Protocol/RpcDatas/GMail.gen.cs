using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMail
    {
        [Order(0)] public GMailHeader Header { get; set; }

        // max context length is 400 bytes
        [Order(1)] public byte[] Context { get; set; }

        [Order(2)] public GRoleInventory AttachObj { get; set; }

        [Order(3)] public uint AttachMoney { get; set; }
    }
}
