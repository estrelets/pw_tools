using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPShopBuyArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int ItemId { get; set; }

        [Order(2)] public int ItemPos { get; set; }

        [Order(3)] public int ItemCount { get; set; }

        [Order(4)] public uint ItemPrice { get; set; }
    }
}
