using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopItem
    {
        [Order(0)] public GRoleInventory Item { get; set; }

        [Order(1)] public uint Price { get; set; }

        [Order(2)] public int Reserved1 { get; set; }

        [Order(3)] public int Reserved2 { get; set; }
    }
}
