using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TradeInventoryRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public GRolePocket Pocket1 { get; set; }

        [Order(2)] public GRolePocket Pocket2 { get; set; }
    }
}
