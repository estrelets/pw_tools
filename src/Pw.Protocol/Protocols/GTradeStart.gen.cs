using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4017)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GTradeStart
    {
        [Order(0)] public uint TId { get; set; }

        [Order(1)] public int Roleid1 { get; set; }

        [Order(2)] public uint Localsid1 { get; set; }

        [Order(3)] public int Roleid2 { get; set; }

        [Order(4)] public uint Localsid2 { get; set; }
    }
}
