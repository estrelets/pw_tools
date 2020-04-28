using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4019)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GTradeEnd
    {
        [Order(0)] public uint TId { get; set; }

        [Order(1)] public int Roleid1 { get; set; }

        [Order(2)] public char NeedReaddb1 { get; set; }

        [Order(3)] public int Roleid2 { get; set; }

        [Order(4)] public char NeedReaddb2 { get; set; }
    }
}
