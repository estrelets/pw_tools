using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8101)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceZoneidToIM
    {
        [Order(0)] public int AId { get; set; }

        [Order(1)] public int ZoneId { get; set; }

        [Order(2)] public long Boottime { get; set; }
    }
}
