using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5018)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACBriefInfo
    {
        [Order(0)] public Dictionary<int, KeyValuePair<int, KeyValuePair<int, int>>> BriefMap { get; set; }
    }
}
