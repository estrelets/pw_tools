using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(926)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopList
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int LocalsId { get; set; }

//×¢ÒâÕâÀïµÄµêÆÌÀàÐÍÎªÑÚÂë¸ñÊ½
        [Order(2)] public int Shoptype { get; set; }
    }
}
