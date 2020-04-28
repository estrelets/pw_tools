using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1131)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceCentralDelivery
    {
        [Order(0)] public char IsCentral { get; set; }

        [Order(1)] public List<int> AcceptedZoneList { get; set; }
    }
}
