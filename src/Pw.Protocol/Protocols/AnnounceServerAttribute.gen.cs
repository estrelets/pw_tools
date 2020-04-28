using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(132)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceServerAttribute
    {
// server attributes 
        [Order(0)] public uint Attr { get; set; }

        [Order(1)] public int Freecreatime { get; set; }

        [Order(2)] public byte ExpRate { get; set; }
    }
}
