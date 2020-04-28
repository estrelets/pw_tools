using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(505)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceZoneid
    {
//game zone id 
        [Order(0)] public char ZoneId { get; set; }

// accounting area id
        [Order(1)] public char AId { get; set; }

// whether clear all online records of this zoneid
        [Order(2)] public char Blreset { get; set; }
    }
}
