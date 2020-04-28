using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1116)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DSAnnounceIdentity
    {
        [Order(0)] public int ZoneId { get; set; }

        [Order(1)] public uint Version { get; set; }

        [Order(2)] public byte[] Edition { get; set; }
    }
}
