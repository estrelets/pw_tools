using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GSysAuctionDetail
    {
        [Order(0)] public GSysAuctionItem Info { get; set; }

        [Order(1)] public GRoleInventory Item { get; set; }
    }
}
