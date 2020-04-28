using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4020)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GTradeDiscard
    {
        [Order(0)] public uint TId { get; set; }

        [Order(1)] public char Paddings { get; set; }
    }
}
