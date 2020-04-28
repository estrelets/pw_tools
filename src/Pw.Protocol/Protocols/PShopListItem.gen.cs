using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(928)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopListItem
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int LocalsId { get; set; }

        [Order(2)] public int ItemId { get; set; }

//0:³öÊÛÎïÆ·;1:ÊÕ¹ºÎïÆ·
        [Order(3)] public char Listtype { get; set; }

//ÇëÇóµÚ¼¸Ò³
        [Order(4)] public int PageNum { get; set; }
    }
}
