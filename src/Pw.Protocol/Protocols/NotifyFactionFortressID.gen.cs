using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4423)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class NotifyFactionFortressID
    {
        [Order(0)] public List<int> Factionids { get; set; }
    }
}
