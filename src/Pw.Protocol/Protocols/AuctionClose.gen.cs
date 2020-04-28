using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(806)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AuctionClose
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint AuctionId { get; set; }

        [Order(2)] public byte Reason { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
