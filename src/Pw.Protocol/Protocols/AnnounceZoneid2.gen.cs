using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(523)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceZoneid2
    {
        [Order(0)] public int ZoneId { get; set; }

        [Order(1)] public int AId { get; set; }

        [Order(2)] public char Blreset { get; set; }
    }
}
