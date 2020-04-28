using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(929)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopListItem_Re
    {
        [Order(0)] public int LocalsId { get; set; }

        [Order(1)] public PShopItemEntry[] Itemlist { get; set; }

        [Order(2)] public char Listtype { get; set; }

        [Order(3)] public int PageNum { get; set; }
    }
}
