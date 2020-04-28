using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(919)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopDrawItem_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int LocalsId { get; set; }

        [Order(2)] public int ItemPos { get; set; }
    }
}
