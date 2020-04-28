using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GFactionStorehouse
    {
        [Order(0)] public long Money { get; set; }

        [Order(1)] public GRoleInventory[] Items { get; set; }

        [Order(2)] public GFactionLog[] Log { get; set; }
    }
}
