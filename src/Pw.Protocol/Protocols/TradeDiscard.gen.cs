using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4014)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TradeDiscard
    {
        [Order(0)] public uint TId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
