using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(411)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class StockCancel
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint TId { get; set; }

        [Order(2)] public int Price { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
