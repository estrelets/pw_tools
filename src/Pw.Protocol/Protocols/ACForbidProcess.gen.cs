using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5015)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACForbidProcess
    {
        [Order(0)] public Dictionary<int, string> ForbidProcess { get; set; }
    }
}
